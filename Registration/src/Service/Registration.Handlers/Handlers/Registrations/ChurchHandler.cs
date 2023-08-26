using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Scode = System.Net.HttpStatusCode;
using System.Data.Common;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Queries;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Church;
using Registration.Mapper.DTOs.Registration.ChurchAddress;
using Registration.Mapper.DTOs.Registration.Member;
using Serilog;

namespace Registration.Handlers.Handlers.Registrations;
public class ChurchHandler : BaseNormalHandler
{
    private IChurchRepository _context;
    private ILogger _logger;

    public ChurchHandler(IChurchRepository context, IMapper mapper, CViewModel viewModel, ILogger logger)
        : base(mapper, viewModel, logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<CViewModel> GetAll(bool active = true)
    {
        _logger.Information("Church - Attemp to get all");

        try
        {
            var churchExpression = Querie<Church>.GetActive(active);

            var churchQuery = _context.GetAll(active);
            var churches = await churchQuery.Where(churchExpression).ToListAsync();

            var churchesReadDto = _mapper.Map<IEnumerable<ReadChurchDto>>(churches);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(churchesReadDto);

            _logger.Information("{totalChurch} Churches found - {churchesName}", churches.Count, churches.Select(x => x.Name));
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.InternalServerError;
            _viewModel!.SetErrors("Internal Error - CH1101A");
            _logger.Error("Fail to get church {error} - CH1101A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        _logger.Information("Church - Attemp to get one");

        try
        {
            var church = await _context.GetOne(id);

            if (church == null)
            {
                _statusCode = (int)Scode.NotFound;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            ReadChurchDto churchReadDto = _mapper.Map<ReadChurchDto>(church);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(churchReadDto);

            _logger.Information("Church found {church}", churchReadDto.Name);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.InternalServerError;
            _viewModel!.SetErrors("Internal Error - CH1103A");
            _logger.Error("Fail to get church {error} - CH1103A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<Church> GetOneChurch(int id)
    {
        var church = await _context.GetOne(id);

        return church;
    }

    public async Task<CViewModel> Create(ChurchAddress churchEditDto)
    {
        _logger.Information("Church - Attemp to create");

        if (ValidateCreateEdit(churchEditDto))
            return _viewModel;

        try
        {
            var address = _mapper.Map<Address>(churchEditDto);
            var church = _mapper.Map<Church>(churchEditDto);
            church.AddAddress(address);

            await _context.Post(church);

            var newChurch = await _context.GetOneNoTracking(church.Id);

            ReadChurchDto churchReadDto = _mapper.Map<ReadChurchDto>(newChurch);

            _statusCode = (int)Scode.Created;
            _viewModel.SetData(churchReadDto);

            _logger.Information("The church {churchName} was created", churchReadDto.Name);
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BadRequest;
            _viewModel!.SetErrors("Request Error - CH1105A");
            _logger.Error("Fail create church {error} - CH1105A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.InternalServerError;
            _viewModel!.SetErrors("Internal Error - CH1105B");
            _logger.Error("Fail create church {error} - CH1105B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Update(ChurchAddress churchEditDto, int id)
    {
        _logger.Information("Church - Attemp to update");

        if (ValidateCreateEdit(churchEditDto))
            return _viewModel;

        try
        {
            var church = await _context.GetOne(id);
            if (church == null)
            {
                _statusCode = (int)Scode.NotFound;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("Church {churchName} not found", churchEditDto.EditChurchDto.Name);

                return _viewModel;
            }

            var editChurch = _mapper.Map<Church>(churchEditDto);
            var editAddress = _mapper.Map<Address>(churchEditDto);

            var address = church.Address;

            address!.UpdateChanges(editAddress);
            church.AddAddress(address);
            church.UpdateChanges(editChurch);

            await _context.Put(church);

            ReadChurchDto churchReadDto = _mapper.Map<ReadChurchDto>(church);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(churchReadDto);

            _logger.Information("Church was updated");
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BadRequest;
            _viewModel!.SetErrors("Request Error - CH1106A");
            _logger.Error("Fail update church {error} - CH1106A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.InternalServerError;
            _viewModel!.SetErrors("Internal Error - CH1106B");
            _logger.Error("Fail update church {error} - CH1106B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
        _logger.Information("Church - Attemp to delte");

        try
        {
            var church = await _context.GetOne(id);
            if (church == null)
            {
                _statusCode = (int)Scode.NotFound;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("Church with id {id} not found", id);

                return _viewModel;
            }

            await _context.Delete(church);

            _statusCode = (int)Scode.OK;

            _logger.Information("Church {churchName} deleted", church.Name);
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BadRequest;
            _viewModel!.SetErrors("Internal Error - CH1107B");
            _logger.Error("Fail delete church {error} - CH1107C", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.InternalServerError;
            _viewModel!.SetErrors("Internal Error - CH1107C");
            _logger.Error("Fail delete church {error} - CH1107C", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetMembers(IMemberRepository memberContext, int churchId)
    {
        _logger.Information("Church - Attemp to get members by church");

        var members = await memberContext.GetAllForChurch()!
            .Where(x => x.ChurchId == churchId)
            .Include(x => x.MemberPost)
                .ThenInclude(m => m.Posts)
            .Include(x => x.MemberOut)
            .Where(x => x.MemberOut.MemberId == null)
            .Include(x => x.Church)
            .OrderBy(x => x.Name)
            .ToListAsync();

        _logger.Information("{totalMembers} members was found for church {churchName}", members.Count, churchId);

        var readMember = _mapper.Map<IEnumerable<ReadMemberDto>>(members);

        _viewModel.SetData(readMember);

        return _viewModel;
    }

    public async Task<CViewModel> GetMembersByMonth(IMemberRepository memberContext, int churchId, string yearMonth)
    {
        _logger.Information("Church - Attemp to get members by church per month");

        if (yearMonth.Length < 6)
        {
            _statusCode = (int)Scode.BadRequest;
            _viewModel!.SetErrors("Request Error. Check the properties - FF1103A");
            _logger.Error("Invalid properties. Check the properties");

            return _viewModel;
        }

        var competence = $"{yearMonth.Substring(0, 4)}-{yearMonth.Substring(4, 2)}-01";

        if (!ValidateCompetence(competence))
        {
            _statusCode = (int)Scode.BadRequest;
            _viewModel!.SetErrors("Request Error. Check the properties - FF1103A");
            _logger.Error("Invalid properties. Check the properties - The competence is not valid");

            return _viewModel;
        }

        var members = await memberContext.GetAllForChurchByMonth()!
           .Where(x => x.ChurchId == churchId)
           .Where(x => x.DateBaptism.Year > 1 && x.DateBaptism.Year <= DateTime.Parse(competence).Year && x.DateBaptism.Month <= DateTime.Parse(competence).Month)
           .OrderBy(x => x.Name)
           .ToListAsync();

        var listMembers = new List<string>();
        members.ForEach(x => listMembers.Add(x.Name!));

        _viewModel.SetData(listMembers);

        _logger.Information("{totalMembers} members was found for church {churchName} by {competence}", members.Count, churchId, competence);

        return _viewModel;
    }

    private bool ValidateCreateEdit(ChurchAddress dto)
    {
        dto.Validate();
        if (!dto.IsValid)
        {
            _statusCode = (int)Scode.BadRequest;
            _viewModel!.SetErrors(dto.GetNotification());
            _logger.Error("Invalid properties. Check the properties");

            return false;
        }

        return true;
    }
}
