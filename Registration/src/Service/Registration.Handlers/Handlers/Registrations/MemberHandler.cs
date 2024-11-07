using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Scode = HttpCodeLib.NumberStatusCode;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Queries;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.Mapper.DTOs.Registration.Member;
using Serilog;
using Registration.DomainCore.CloudAbstration;
using Microsoft.Extensions.Configuration;
using Registration.Handlers.CloudHandlers;
using Microsoft.Extensions.Caching.Memory;
using Member = Registration.DomainBase.Entities.Registrations.Member;

namespace Registration.Handlers.Handlers.Registrations;
public sealed class MemberHandler : BaseRegisterNormalHandler
{
    private readonly IMemberRepository _context;

    private readonly PostHandler _postHandler;
    private readonly ChurchHandler _churchHandler;
    private readonly MemberBridgesHandler _memberBridgesHandler;
    private readonly ILogger _logger;
    private readonly IConfiguration _configuration;
    private readonly IImageStorage _storage;

    private OperationsHandler _operationsHandler;
    private string pathStorageName = "members";

    private readonly IMemoryCache _cache;
    private const string _cacheKey = "MEMBERS";
    private static Dictionary<string, IEnumerable<ReadMemberDto>?> HashGetByPeriod = new();

    public MemberHandler(IMemberRepository context,
        IMapper mapper,
        CViewModel viewModel,
        OperationsHandler operationsHandler,
        PostHandler postHandler,
        ChurchHandler churchHandler,
        MemberBridgesHandler memberBridgesHandler,
        ILogger logger,
        IConfiguration configuration,
        IImageStorage storage,
        IMemoryCache cache) : base(mapper, viewModel)
    {
        _context = context;
        _operationsHandler = operationsHandler;
        _postHandler = postHandler;
        _churchHandler = churchHandler;
        _memberBridgesHandler = memberBridgesHandler;
        _logger = logger;
        _configuration = configuration;
        _storage = storage;
        _cache = cache;
    }

    protected override async Task<bool> MonthWorkIsBlockAsync(string competence, int churchId)
    {
        var yearMonth = DateTime.Parse(competence).ToString("yyyyMM");
        var monthWork = await _operationsHandler.GetOneByCompetence(yearMonth, churchId);

        if (monthWork is not null)
            return monthWork.Active == false ? false : true;

        return false;
    }


    public async Task<CViewModel> GetAll(bool active = true)
    {
        IEnumerable<ReadMemberDto>? membersReadDto;

        try
        {
            membersReadDto = await _cache.GetOrCreateAsync(_cacheKey, async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeToExpirationCache;

                var memberExpression = Querie<Member>.GetActive(active);

                var membersQuery = _context.GetAllNoTracking();
                var members = await membersQuery!.Where(memberExpression).ToListAsync();

                return _mapper.Map<IEnumerable<ReadMemberDto>>(members);
            });

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(membersReadDto);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MB1101A");
            _logger.Error("Fail. get all {error} - MB1101A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        Member? member;

        try
        {
            member = await _cache.GetOrCreateAsync($"{_cacheKey}-{id}", async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeToExpirationCache;

                return await _context.GetOne(id);
            });

            if (member == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The member with id {id} was not found", id);
                
                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var memberReadDto = _mapper.Map<ReadMemberDto>(member);
            _viewModel.SetData(memberReadDto);

            _logger.Information("The member was found", member.Name);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MB1102A");
            _logger.Error("Fail. get one {error} MB1102A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetByCode(string userCode)
    {
        ReadMemberDto? memberReadDto;
        Member? member = null;

        try
        {
            memberReadDto = await _cache.GetOrCreateAsync($"{_cacheKey}-{userCode}", async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeToExpirationCache;

                member = await _context.GetByCode(userCode);
                return _mapper.Map<ReadMemberDto>(member);
            });

            if (memberReadDto == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The member with code {code} was not found", userCode);

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(memberReadDto);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MB1103A");
            _logger.Error("Fail - error get by code - {userCode} - MB1103A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditMemberDto dto)
    {
        dto.Validate();
        if (!dto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(dto.GetNotification());
            _logger.Error("Invalid properties. Check the properties");

            return _viewModel;
        }

        try
        {
            var church = await _churchHandler.GetOneChurch(dto.ChurchId);

            var post = await _postHandler.GetByIds(dto.PostIds!.ToArray());

            if (church == null || post == false)
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - MB1104A");
                _logger.Error("The member church or member post was not found. Check the properties");

                return _viewModel;
            }

            //if have member out
            if (dto.EditMemberOutDto != null)
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Member out should not have value in create member");
                _logger.Warning("Attemp create member with output data");

                return _viewModel;
            }

            var member = _mapper.Map<Member>(dto);
            member.AddChurch(church!);
            member.UpdateData();
            if (dto.base64Image != null)
                member.SetPhoto();

            await _context.Post(member)!;

            _cache.Remove(_cacheKey);
            foreach (var item in HashGetByPeriod)
                _cache.Remove(item.Key);

            await SaveImageStoreAsync(member, dto.base64Image);

            await CheckMemberMoviment(dto, member);

            await _memberBridgesHandler.CreateMemberPostAsync(member.Id, dto.PostIds!.ToArray());

            var newMember = await _context.GetOneNoTracking(member.Id);

            ReadMemberDto memberReadDto = _mapper.Map<ReadMemberDto>(newMember);

            _statusCode = (int)Scode.CREATED;
            _viewModel.SetData(memberReadDto);
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - MB1104B");
            _logger.Error("Fail create one {error} - MB1104B", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - MB1104C");
            _logger.Error("Fail create one {error} - MB1104B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Update(EditMemberDto dto, int id)
    {
        dto.Validate();
        if (!dto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(dto.GetNotification());
            _logger.Error("Invalid properties. Check the properties");

            return _viewModel;
        }

        try
        {
            var member = await _context.GetOne(id);
            if (member == null)
            {
                _statusCode = (int)Scode.OK; ;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The member with id {id} was not found", id);

                return _viewModel;
            }

            var church = await _churchHandler.GetOneChurch(dto.ChurchId);
            var post = await _postHandler.GetByIds(dto.PostIds!.ToArray());

            if (church == null || post == false)
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - MB1104A");
                _logger.Error("The member church or member post was not found");

                return _viewModel;
            }

            await CheckMemberMoviment(dto, member);

            var editMember = _mapper.Map<Member>(dto);
            member.UpdateChanges(editMember);
            if (dto.base64Image != null)
                member.SetPhoto();

            await _context.Put(member);

            _cache.Remove(_cacheKey);
            _cache.Remove($"{_cacheKey}-{id}");
            _cache.Remove($"{_cacheKey}-{member.Code}");
            _cache.Remove($"{_cacheKey}-{dto.ChurchId}-{member.Code}");
            foreach (var item in HashGetByPeriod)
                _cache.Remove(item.Key);

            await SaveImageStoreAsync(member, dto.base64Image);

            await _memberBridgesHandler.DeletePostByMemberAsync(member.Id);
            await _memberBridgesHandler.CreateMemberPostAsync(member.Id, dto.PostIds!.ToArray());

            _statusCode = (int)Scode.OK;
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - MB1105D");
            _logger.Error("Fail update one {error} - MB1105D", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - MB1105E");
            _logger.Error("Fail update one {error} - MB1105E", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
        try
        {
            var member = await _context.GetOne(id);
            if (member == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The member with id {id} was not found", id);
                return _viewModel;
            }

            await _context.Delete(member);

            _cache.Remove(_cacheKey);
            _cache.Remove($"{_cacheKey}-{id}");
            _cache.Remove($"{_cacheKey}-{member.Code}");
            foreach(var item in HashGetByPeriod)
                _cache.Remove(item.Key);

            await _memberBridgesHandler.DeleteMemberOutByMemberAsync(member.Id);
            await _memberBridgesHandler.DeleteMemberInByMemberAsync(member.Id);

            _statusCode = (int)Scode.OK;
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - MB1106A");
            _logger.Error("Fail delete one {error} - MB1106A");
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MB1106B");
            _logger.Error("Fail delete one {error} - MB1106B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOneByChurch(int churchId, string userCode)
    {
        ReadMemberDto? memberReadDto;
        Member? member = null;

        try
        {
            memberReadDto = await _cache.GetOrCreateAsync($"{_cacheKey}-{churchId}-{userCode}", async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeToExpirationCache;

                member = await _context.GetAllForChurch()
                 .Where(x => x.ChurchId == churchId && x.Code == userCode)
                 .Include(x => x.MemberOut)
                 .Include(x => x.MemberPost)
                     .ThenInclude(y => y.Posts)
                 .Include(x => x.MemberIn)
                 .FirstOrDefaultAsync();

                return _mapper.Map<ReadMemberDto>(member);
            });

            if (memberReadDto == null)
            {
                _statusCode = (int)Scode.OK;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("Member with code {code} was not found for church {churchName}", userCode, churchId);
                return _viewModel;
            }

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(memberReadDto);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MB1107A");
            _logger.Error("Fail to get one with code {code}", userCode);
        }

        return _viewModel;
    }

    private async Task CheckMemberMoviment(EditMemberDto memberEditDto, Member member)
    {
        //create mermberIn
        if (memberEditDto.EditMemberInDto != null)
        {
            memberEditDto.EditMemberInDto.MemberId = member.Id;
            if (!await _memberBridgesHandler.CreateMemberInAsync(memberEditDto.EditMemberInDto!))
            {
                _statusCode = (int)Scode.OK;
                _viewModel!.SetErrors("Request Error. we have a problema for set data memberIn");
                _logger.Error("We have a problema for set data memberIn - code {code}", member.Name);
            }
        }

        //create memberout
        if (memberEditDto.EditMemberOutDto != null)
        {
            memberEditDto.EditMemberOutDto.MemberId = member.Id;
            if (!await _memberBridgesHandler.UpdateMemberOutAsync(memberEditDto.EditMemberOutDto!))
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Error update memberOut. Check the properties - MB1105C");
                _logger.Error("Error update memberOut. Check the properties - code {code}", member.Name);
            }
            else
            {
                member.Activate(false);
            }
        }
        else
        {
            await _memberBridgesHandler.DeleteMemberOutByMemberAsync(member.Id);
            member.Activate(true);
        }
    }

    public async Task<CViewModel> GetMemberByPeriodAsync(int churchId, string initialDate, string finalDate, bool active)
    {
        IEnumerable<ReadMemberDto>? readDto;

        try
        {
            if (!ValidateCompetence(initialDate) | !ValidateCompetence(finalDate))
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - OF01B");
                _logger.Error("The competence {initialDate}~{finalDate} is invalid", initialDate, finalDate);

                return _viewModel;
            }

            var expression = Querie<Member>.GetActive(active);

            initialDate = DateTime.Parse(initialDate).ToString("yyyy-MM-dd");
            finalDate = DateTime.Parse(finalDate).ToString("yyyy-MM-dd");
            var cacheName = $"{_cacheKey}-{initialDate}-{finalDate}";

            readDto = await _cache.GetOrCreateAsync(cacheName, async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeToExpirationCache;

                var query = _context.GetAllForChurch();
                var model = await query!
                    .Where(expression)
                    .Where(x => x.ChurchId == churchId)
                    .Where(x => x.DateRegister >= DateTime.Parse(initialDate))
                    .Where(x => x.DateRegister <= DateTime.Parse(finalDate))
                    .ToListAsync();

                return _mapper.Map<IEnumerable<ReadMemberDto>>(model);
            });

            HashGetByPeriod.TryAdd(cacheName, readDto);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(readDto);
        }
        catch (Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MB1106A");
            _logger.Error("Failt get by period", ex.Message);
        }

        return _viewModel;
    }

    private async Task SaveImageStoreAsync(Member member, string? base64Image)
    {
        ModelImage membersImage = new("members", member.Code!, _logger, _storage);
        await membersImage.SaveImageStoreAsync(base64Image);
    }

}