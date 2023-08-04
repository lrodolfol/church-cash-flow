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

namespace Registration.Handlers.Handlers.Registrations;
public class ChurchHandler : BaseNormalHandler
{
    private IChurchRepository _context;
    public ChurchHandler(IChurchRepository context, IMapper mapper, CViewModel viewModel)
        : base(mapper, viewModel)
    {
        _context = context;
    }

    public async Task<CViewModel> GetAll(bool active = true)
    {
        try
        {
            var churchExpression = Querie<Church>.GetActive(active);

            var churchQuery = _context.GetAll(active);
            var churches = await churchQuery.Where(churchExpression).ToListAsync();

            var churchesReadDto = _mapper.Map<IEnumerable<ReadChurchDto>>(churches);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(churchesReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.InternalServerError;
            _viewModel!.SetErrors("Internal Error - CH1101A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
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
        }
        catch
        {
            _statusCode = (int)Scode.InternalServerError;
            _viewModel!.SetErrors("Internal Error - CH1103A");
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
        churchEditDto.Validate();
        if (!churchEditDto.IsValid)
        {
            _statusCode = (int)Scode.BadRequest;
            _viewModel!.SetErrors(churchEditDto.GetNotification());

            return _viewModel;
        }

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
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BadRequest;
            _viewModel!.SetErrors("Request Error - CH1105A");
        }
        catch
        {
            _statusCode = (int)Scode.InternalServerError;
            _viewModel!.SetErrors("Internal Error - CH1105B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Update(ChurchAddress churchEditDto, int id)
    {
        churchEditDto.Validate();
        if (!churchEditDto.IsValid)
        {
            _statusCode = (int)Scode.BadRequest;
            _viewModel!.SetErrors(churchEditDto.GetNotification());

            return _viewModel;
        }

        try
        {
            var church = await _context.GetOne(id);
            if (church == null)
            {
                _statusCode = (int)Scode.NotFound;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            var editChurch = _mapper.Map<Church>(churchEditDto);
            var editAddress = _mapper.Map<Address>(churchEditDto);

            var address = church.Address;

            address.UpdateChanges(editAddress);
            church.AddAddress(address);
            church.UpdateChanges(editChurch);

            await _context.Put(church);

            ReadChurchDto churchReadDto = _mapper.Map<ReadChurchDto>(church);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(churchReadDto);
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BadRequest;
            _viewModel!.SetErrors("Request Error - CH1106A");
        }
        catch
        {
            _statusCode = (int)Scode.InternalServerError;
            _viewModel!.SetErrors("Internal Error - CH1106B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
        try
        {
            var church = await _context.GetOne(id);
            if (church == null)
            {
                _statusCode = (int)Scode.NotFound;
                _viewModel!.SetErrors("Object not found");
            }

            await _context.Delete(church);

            _statusCode = (int)Scode.OK;
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BadRequest;
            _viewModel!.SetErrors("Internal Error - CH1107B");
        }
        catch
        {
            _statusCode = (int)Scode.InternalServerError;
            _viewModel!.SetErrors("Internal Error - CH1107C");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetMembers(IMemberRepository memberContext, int churchId)
    {
        var members = await memberContext.GetAllForChurch()
            .Where(x => x.ChurchId == churchId)
            .Include(x => x.MemberPost)
                .ThenInclude(m => m.Posts)
            .Include(x => x.MembersOut)
            .Where(x => x.MembersOut.MemberId == null)
            .Include(x => x.Church)
            .OrderBy(x => x.Name)
            .ToListAsync();

        var readMember = _mapper.Map<IEnumerable<ReadMemberDto>>(members);

        _viewModel.SetDataErros(readMember, null);

        return _viewModel;
    }

    public async Task<CViewModel> GetMembersByMonth(IMemberRepository memberContext, int churchId, string yearMonth)
    {
        if (yearMonth.Length < 6)
        {
            _statusCode = (int)Scode.BadRequest;
            _viewModel!.SetErrors("Request Error. Check the properties - FF1103A");

            return _viewModel;
        }

        var competence = $"{yearMonth.Substring(0, 4)}-{yearMonth.Substring(4, 2)}-01";

        if (!ValidateCompetence(competence))
        {
            _statusCode = (int)Scode.BadRequest;
            _viewModel!.SetErrors("Request Error. Check the properties - FF1103A");

            return _viewModel;
        }

        var members = await memberContext.GetAllForChurchByMonth()
           .Where(x => x.ChurchId == churchId)
           .Where(x => x.DateBaptism.Year > 1 && x.DateBaptism.Year <= DateTime.Parse(competence).Year && x.DateBaptism.Month <= DateTime.Parse(competence).Month)
           .OrderBy(x => x.Name)
           .ToListAsync();

        var listMembers = new List<string>();
        members.ForEach(x => listMembers.Add(x.Name));

        _viewModel.SetDataErros(listMembers, null);

        return _viewModel;
    }
}
