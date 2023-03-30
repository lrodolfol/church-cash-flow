using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Scode = System.Net.HttpStatusCode;
using System.Data.Common;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.ContextAbstraction;
using Registration.Handlers.Queries;
using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.Church;
using Registration.Mapper.DTOs.ChurchAddress;
using Registration.DomainCore.ViewModelAbstraction;

namespace ChurchCashFlow.Handlers;
public class ChurchHandler : IHandler<ReadChurchDto, ChurchAddress>
{
    private IChurchRepository _context;
    private IMapper _mapper;
    private int _statusCode;
    private readonly CViewModel _viewModel;

    public ChurchHandler(IChurchRepository context, IMapper mapper, CViewModel viewModel)
    {
        _context = context;
        _mapper = mapper;
        _viewModel = viewModel;
    }

    public int GetStatusCode() => (int)_statusCode;
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
            _viewModel.SetErrors("Internal Error - CH1101A");
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
                _viewModel.SetErrors("Object not found");

                return _viewModel;
            }

            ReadChurchDto churchReadDto = _mapper.Map<ReadChurchDto>(church);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(churchReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.InternalServerError;
            _viewModel.SetErrors("Internal Error - CH1103A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(ChurchAddress churchEditDto)
    {
        churchEditDto.Validate();
        if (!churchEditDto.IsValid)
        {
            _statusCode = (int)Scode.BadRequest;
            _viewModel.SetErrors(churchEditDto.GetNotification());

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
            _viewModel.SetErrors("Request Error - CH1105A");
        }
        catch
        {
            _statusCode = (int)Scode.InternalServerError;
            _viewModel.SetErrors("Internal Error - CH1105B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Update(ChurchAddress churchEditDto, int id)
    {
        churchEditDto.Validate();
        if (!churchEditDto.IsValid)
        {
            _statusCode = (int)Scode.BadRequest;
            _viewModel.SetErrors(churchEditDto.GetNotification());

            return _viewModel;
        }

        try
        {
            var church = await _context.GetOne(id);
            if (church == null)
            {
                _statusCode = (int)Scode.NotFound;
                _viewModel.SetErrors("Object not found");

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
            _viewModel.SetErrors("Request Error - CH1106A");
        }
        catch
        {
            _statusCode = (int)Scode.InternalServerError;
            _viewModel.SetErrors("Internal Error - CH1106B");
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
                _viewModel.SetErrors("Object not found");
            }

            await _context.Delete(church);

            _statusCode = (int)Scode.OK;
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BadRequest;
            _viewModel.SetErrors("Internal Error - CH1107B");
        }
        catch
        {
            _statusCode = (int)Scode.InternalServerError;
            _viewModel.SetErrors("Internal Error - CH1107C");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetMembers(IMemberRepository memberContext, int churchId)
    {
        var members = await memberContext.GetAllForChurch()
            .Where(x => x.ChurchId == churchId)
            .OrderBy(x => x.Name)
            .ToListAsync();

        var listMembers = new List<string>();
        members.ForEach(x => listMembers.Add(x.Name));

        _viewModel.SetDataErros(listMembers, null);

        return _viewModel;
    }
}
