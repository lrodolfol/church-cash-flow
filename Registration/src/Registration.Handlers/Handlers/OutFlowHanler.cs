using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Scode = HttpCodeLib.NumberStatusCode;
using System.Data.Common;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Queries;
using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.OutFlow;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.DomainCore.HandlerAbstraction;

namespace Registration.Handlers.Handlers;
public sealed class OutFlowHanler : Handler
{
    private IOutFlowRepository _context;

    public OutFlowHanler(IOutFlowRepository context, IMapper mapper, CViewModel viewModel) : base(mapper, viewModel)
    {
        _context = context;
    }

    public async Task<CViewModel> GetAll(int churchId, bool active = true)
    {
        try
        {
            var outFlowExpression = Querie<OutFlow>.GetActive(active);

            var outFlowQuery = _context.GetAll();
            var outFlow = await outFlowQuery
                .Where(outFlowExpression)
                .Where(x => x.ChurchId == churchId)
                .Include(x => x.OutFlowKind)
                .Include(x => x.Church)
                .ToListAsync();

            var outFlowReadDto = _mapper.Map<IEnumerable<ReadOutFlowDto>>(outFlow);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(outFlowReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error - OT1101A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        try
        {
            var outFlow = await _context.GetOne(id);
            if (outFlow == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel.SetErrors("Object not found");

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var outFlowReadDto = _mapper.Map<ReadOutFlowDto>(outFlow);
            _viewModel.SetData(outFlowReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error - OT1102A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditOutFlowDto outFlowEditDto)
    {
        outFlowEditDto.Validate();
        if (!outFlowEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetErrors(outFlowEditDto.GetNotification());

            return _viewModel;
        }

        try
        {
            var outFlow = _mapper.Map<OutFlow>(outFlowEditDto);
            outFlow.CalculateTotalAmount();

            //verificar o totalAmount
            await _context.Post(outFlow)!;

            var newOutFlow = await _context.GetOne(outFlow.Id);

            var outFlowReadDto = _mapper.Map<ReadOutFlowDto>(newOutFlow);
            _statusCode = (int)Scode.CREATED;

            _viewModel.SetData(outFlowReadDto);
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetErrors("Request Error. Check the properties - OT1103A");
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error. - OT1103B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Update(EditOutFlowDto outFlowEditDto, int id)
    {
        outFlowEditDto.Validate();
        if (!outFlowEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetErrors(outFlowEditDto.GetNotification());
        }

        try
        {
            var outFlow = await _context.GetOne(id);
            if (outFlow == null)
            {
                _statusCode = 404;
                _viewModel.SetErrors("Object not found");
            }

            var editOutFlow = _mapper.Map<OutFlow>(outFlowEditDto);
            outFlow.UpdateChanges(editOutFlow);
            
            await _context.Put(outFlow);

            var userReadDto = _mapper.Map<ReadOutFlowDto>(editOutFlow);

            _statusCode = (int)Scode.OK;
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - OT1104A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error. - OT1104B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
        try
        {
            var otFlow = await _context.GetOne(id);
            if (otFlow == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel.SetErrors("Object not found");
            }

            await _context.Delete(otFlow);

            _statusCode = (int)Scode.OK;
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - OT1105A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error - OT1105B");
        }

        return _viewModel;
    }
}