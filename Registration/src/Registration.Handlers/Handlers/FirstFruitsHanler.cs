using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Scode = HttpCodeLib.NumberStatusCode;
using System.Data.Common;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Queries;
using Registration.DomainBase.Entities;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.FirstFruits;
using Registration.DomainCore.HandlerAbstraction;
using Microsoft.VisualBasic;

namespace Registration.Handlers.Handlers;
public class FirstFruitsHanler : Handler
{
    private IFirstFruitsRepository _context;
    private OperationsHandler _operationsHandler;

    public FirstFruitsHanler(IFirstFruitsRepository context, CViewModel viewModel, IMapper mapper, OperationsHandler operationsHandler) 
        : base(mapper, viewModel)
    {
        _context = context;
        _operationsHandler = operationsHandler;
    }

    protected async Task<bool> MonthWorkIsBlock(string competence, int churchId)
    {
        var yearMonth = DateTime.Parse(competence).ToString("yyyyMM");
        var monthWork = await _operationsHandler.GetOneByCompetence(yearMonth, churchId);

        return monthWork == null ? false : true;
    }

    public async Task<CViewModel> GetAll(int churchId, bool active = true)
    {
        try
        {
            var firstFruitsExpression = Querie<FirstFruits>.GetActive(active);

            var outFlowQuery = _context.GetAll(churchId);
            var firstFruits = await outFlowQuery
                .Where(firstFruitsExpression)
                .Include(x => x.Member)
                .Include(x => x.OfferingKind)
                .Include(x => x.Church)
                .ToListAsync();

            var firstFruitsReadDto = _mapper.Map<IEnumerable<ReadFirstFruitsDto>>(firstFruits);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(firstFruitsReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error - FF1101A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetAllByCompetence(int churchId, string competence, bool active = true)
    {
        try
        {
            if (!ValidateCompetence(competence))
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel.SetErrors("Request Error. Check the properties - FF1103A");

                return _viewModel;
            }

            var firstFruitsExpression = Querie<FirstFruits>.GetActive(active);

            var fruitsQuery = _context.GetAll(churchId);
            var fruits = await fruitsQuery
                .Where(firstFruitsExpression)
                .Where(x => x.Competence == DateTime.Parse(competence).ToString("MM/yyyy"))
                .Include(x => x.Church)
                .Include(x => x.OfferingKind)
                .Include(x => x.Member)
                .ToListAsync();

            var fruitsReadDto = _mapper.Map<IEnumerable<ReadFirstFruitsDto>>(fruits);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(fruitsReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error - FF1103B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        try
        {
            var firstFruits = await _context.GetOne(id);
            if (firstFruits == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel.SetErrors("Object not found");

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var outFlowReadDto = _mapper.Map<ReadFirstFruitsDto>(firstFruits);
            _viewModel.SetData(outFlowReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error - FF1102A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditFirstFruitsDto firstFruitsEditDto)
    {
        firstFruitsEditDto.Validate();
        if (!firstFruitsEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetErrors(firstFruitsEditDto.GetNotification());

            return _viewModel;
        }

        if(await MonthWorkIsBlock(firstFruitsEditDto.Competence, firstFruitsEditDto.ChurchId))
        {
            _statusCode = (int)Scode.NOT_ACCEPTABLE;
            _viewModel.SetErrors("This competence has already been closed!");

            return _viewModel;
        }


        try
        {
            var firstFruits = _mapper.Map<FirstFruits>(firstFruitsEditDto);
            await _context.Post(firstFruits)!;

            var newFirstFruits = await _context.GetOne(firstFruits.Id);

            var firstFruitsReadDto = _mapper.Map<ReadFirstFruitsDto>(newFirstFruits);
            _statusCode = (int)Scode.CREATED;

            _viewModel.SetData(firstFruitsReadDto);
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetErrors("Request Error. Check the properties - FF1103A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error - FF1103B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Update(EditFirstFruitsDto firstFruitsEditDto, int id)
    {
        firstFruitsEditDto.Validate();
        if (!firstFruitsEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetErrors(firstFruitsEditDto.GetNotification());
        }

        try
        {
            var firstFruits = await _context.GetOne(id);
            if (firstFruits == null)
            {
                _statusCode = 404;
                _viewModel.SetErrors("Object not found");
            }

            var editTithes = _mapper.Map<FirstFruits>(firstFruitsEditDto);
            firstFruits.UpdateChanges(editTithes);
            
            await _context.Put(firstFruits);

            _statusCode = (int)Scode.OK;
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - FF1104A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error - FF1104B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
        try
        {
            var firstFruits = await _context.GetOne(id);
            if (firstFruits == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel.SetErrors("Object not found");
            }

            await _context.Delete(firstFruits);

            _statusCode = (int)Scode.OK;
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - FF1105A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error - FF1105B");
        }

        return _viewModel;
    }
}