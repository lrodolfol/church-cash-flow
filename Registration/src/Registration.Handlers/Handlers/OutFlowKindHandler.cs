using AutoMapper;
using Scode = HttpCodeLib.NumberStatusCode;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Registration.Handlers.Queries;
using Registration.DomainBase.Entities;
using Registration.DomainCore.ContextAbstraction;
using Registration.Mapper.DTOs.OutFlowKind;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.DomainCore.HandlerAbstraction;

namespace Registration.Handlers.Handlers;
public class OutFlowKindHandler : Handler
{
    private IOutFlowKindRepository _context;

    public OutFlowKindHandler(IOutFlowKindRepository context, IMapper mapper, CViewModel viewModel) : base(mapper, viewModel)
    {
        _context = context;
    }

    public async Task<CViewModel> GetAll(bool active = true)
    {
        try
        {
            var ouFlowKindExpression = Querie<OutFlowKind>.GetActive(active);

            var outFlowKindQuery = _context.GetAll();
            var outFlowKind = await outFlowKindQuery.Where(ouFlowKindExpression).ToListAsync();

            var outFlowKindReadDto = _mapper.Map<IEnumerable<ReadOutFlowKindDto>>(outFlowKind);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(outFlowKindReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error - OT101A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        try
        {
            var OfferingKind = await _context.GetOneAsNoTracking(id);
            if (OfferingKind == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel.SetErrors("Object not found");

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var OfferingKindReadDto = _mapper.Map<ReadOutFlowKindDto>(OfferingKind);
            _viewModel.SetData(OfferingKindReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error - OT102A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditOutFlowKindDto outFlowKindEditDto)
    {
        outFlowKindEditDto.Validate();
        if (!outFlowKindEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetErrors(outFlowKindEditDto.GetNotification());

            return _viewModel;
        }

        try
        {
            var OfferingKind = _mapper.Map<OutFlowKind>(outFlowKindEditDto);

            await _context.Post(OfferingKind)!;

            var newOutFlow = await _context.GetOne(OfferingKind.Id);

            ReadOutFlowKindDto outFlowRead = _mapper.Map<ReadOutFlowKindDto>(newOutFlow);
            _statusCode = (int)Scode.CREATED;

            _viewModel.SetData(outFlowRead);
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - OT103A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error. - OT103B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
        try
        {
            var outFlowKind = await _context.GetOne(id);
            if (outFlowKind == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel.SetErrors("Object not found");

                return _viewModel;
            }

            await _context.Delete(outFlowKind);

            _statusCode = (int)Scode.OK;
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - OT104A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error - OT104B");
        }

        return _viewModel;
    }
}