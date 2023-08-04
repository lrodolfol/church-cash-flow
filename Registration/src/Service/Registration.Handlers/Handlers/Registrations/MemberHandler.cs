using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Scode = HttpCodeLib.NumberStatusCode;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Queries;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Member;

namespace Registration.Handlers.Handlers.Registrations;
public sealed class MemberHandler : BaseRegisterNormalHandler
{
    private readonly IMemberRepository _context;

    private readonly PostHandler _postHandler;
    private readonly ChurchHandler _churchHandler;
    private readonly MemberPostHandler _memberPostHandler;

    private OperationsHandler _operationsHandler;

    public MemberHandler(IMemberRepository context,
        IMapper mapper,
        CViewModel viewModel,
        OperationsHandler operationsHandler,
        PostHandler postHandler,
        ChurchHandler churchHandler,
        MemberPostHandler memberPostHandler) : base(mapper, viewModel)
    {
        _context = context;
        _operationsHandler = operationsHandler;
        _postHandler = postHandler;
        _churchHandler = churchHandler;
        _memberPostHandler = memberPostHandler;
    }

    protected override async Task<bool> MonthWorkIsBlockAsync(string competence, int churchId)
    {
        var yearMonth = DateTime.Parse(competence).ToString("yyyyMM");
        var monthWork = await _operationsHandler.GetOneByCompetence(yearMonth, churchId);

        return monthWork == null ? false : true;
    }

    public async Task<CViewModel> GetAll(bool active = true)
    {
        try
        {
            var memberExpression = Querie<Member>.GetActive(active);

            var membersQuery = _context.GetAllNoTracking();
            var members = await membersQuery!.Where(memberExpression).ToListAsync();

            var membersReadDto = _mapper.Map<IEnumerable<ReadMemberDto>>(members);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(membersReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MB1101A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        try
        {
            var member = await _context.GetOne(id);
            if (member == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var memberReadDto = _mapper.Map<ReadMemberDto>(member);
            _viewModel.SetData(memberReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MB1102A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetByCode(string userCode)
    {
        try
        {
            var member = await _context.GetByCode(userCode);
            if (member == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var memberReadDto = _mapper.Map<ReadMemberDto>(member);
            _viewModel.SetData(memberReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MB1103A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditMemberDto memberEditDto)
    {
        memberEditDto.Validate();
        if (!memberEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(memberEditDto.GetNotification());

            return _viewModel;
        }

        try
        {
            var church = await _churchHandler.GetOneChurch(memberEditDto.ChurchId);

            var post = await _postHandler.GetByIds(memberEditDto.PostIds!.ToArray());

            if (church == null || post == false)
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - MB1104A");

                return _viewModel;
            }

            var member = _mapper.Map<Member>(memberEditDto);
            member.AddChurch(church!);
            member.GenerateCode();

            await _context.Post(member)!;

            await _memberPostHandler.Create(member.Id, memberEditDto.PostIds!.ToArray());

            var newMember = await _context.GetOneNoTracking(member.Id);

            ReadMemberDto memberReadDto = _mapper.Map<ReadMemberDto>(newMember);
            _statusCode = (int)Scode.CREATED;

            _viewModel.SetData(memberReadDto);
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - MB1104B");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - MB1104C");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Update(EditMemberDto memberEditDto, int id)
    {
        memberEditDto.Validate();
        if (!memberEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(memberEditDto.GetNotification());

            return _viewModel;
        }

        try
        {
            var member = await _context.GetOne(id);
            if (member == null)
            {
                _statusCode = 404;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            var church = await _churchHandler.GetOneChurch(memberEditDto.ChurchId);
            var post = await _postHandler.GetByIds(memberEditDto.PostIds!.ToArray());

            if (church == null || post == false)
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - MB1104A");

                return _viewModel;
            }

            var editMember = _mapper.Map<Member>(memberEditDto);
            member.UpdateChanges(editMember);

            await _context.Put(member);

            await _memberPostHandler.Delete(member.Id);
            await _memberPostHandler.Create(member.Id, memberEditDto.PostIds!.ToArray());

            _statusCode = (int)Scode.OK;
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - MB1105B");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - MB1105C");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
        try
        {
            var user = await _context.GetOne(id);
            if (user == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            await _context.Delete(user);

            _statusCode = (int)Scode.OK;
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - MB1106A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MB1106B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOneByChurch(int churchId, string userCode)
    {
        try
        {
            var member = await _context.GetAllForChurch()
                .Where(x => x.ChurchId == churchId && x.Code == userCode)
                .Include(x => x.MembersOut)
                .Include(x => x.MemberPost)
                    .ThenInclude(y => y.Posts)
                .FirstOrDefaultAsync();

            if (member == null)
            {
                _statusCode = (int)Scode.OK;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var memberReadDto = _mapper.Map<ReadMemberDto>(member);
            _viewModel.SetData(memberReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MB1107A");
        }

        return _viewModel;
    }
}