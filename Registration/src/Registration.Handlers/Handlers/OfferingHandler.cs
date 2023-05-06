﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.Entities;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Queries;
using Registration.Mapper.DTOs.Offering;
using System.Data.Common;
using Scode = HttpCodeLib.NumberStatusCode;

namespace Registration.Handlers.Handlers;
public sealed class OfferingHandler : Handler
{
    private IOfferingRepository _context;
    private OperationsHandler _operationsHandler;

    public OfferingHandler(IOfferingRepository context, IMapper mapper, CViewModel viewModel, OperationsHandler operationsHandler) : base(mapper, viewModel)
    {
        _context = context;
        _operationsHandler = operationsHandler;
    }

    protected override async Task<bool> MonthWorkIsBlock(string competence, int churchId)
    {
        var yearMonth = DateTime.Parse(competence).ToString("yyyyMM");
        var monthWork = await _operationsHandler.GetOneByCompetence(yearMonth, churchId);

        return monthWork == null ? false : true;
    }

    public async Task<CViewModel> GetAll(int churchId, bool active = true)
    {
        try
        {
            var offeringExpression = Querie<Offering>.GetActive(active);

            var offeringQuery = _context.GetAll(churchId);
            var offering = await offeringQuery
                .Where(offeringExpression)
                .Include(x => x.MeetingKind)
                .Include(x => x.OfferingKind)
                .Include(x => x.Church)
                .ToListAsync();

            var offeringReadDto = _mapper.Map<IEnumerable<ReadOfferingDto>>(offering);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(offeringReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - FF1101A");
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
                _viewModel!.SetErrors("Request Error. Check the properties - FF1102A");

                return _viewModel;
            }

            var offeringExpression = Querie<Offering>.GetActive(active);

            var offeringQuery = _context.GetAll(churchId);
            var offering = await offeringQuery
                .Where(offeringExpression)
                .Where(x => x.Day.Year == DateTime.Parse(competence).Year && x.Day.Month == DateTime.Parse(competence).Month)
                .Include(x => x.MeetingKind)
                .Include(x => x.OfferingKind)
                .Include(x => x.Church)
                .ToListAsync();

            var offeringReadDto = _mapper.Map<IEnumerable<ReadOfferingDto>>(offering);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(offeringReadDto);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - FF1102B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        try
        {
            var offering = await _context.GetOne(id);
            if (offering == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var offeringReadDto = _mapper.Map<ReadOfferingDto>(offering);
            _viewModel.SetData(offeringReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - FF1103A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditOfferingDto offeringEditDto)
    {
        offeringEditDto.Validate();
        if (!offeringEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(offeringEditDto.GetNotification());

            return _viewModel;
        }

        if (await MonthWorkIsBlock(offeringEditDto.Day.ToString(), offeringEditDto.ChurchId))
        {
            _statusCode = (int)Scode.NOT_ACCEPTABLE;
            _viewModel!.SetErrors("This competence has already been closed!");

            return _viewModel;
        }

        try
        {
            var offering = _mapper.Map<Offering>(offeringEditDto);

            await _context.Post(offering);

            var newOffering = await _context.GetOneAsNoTracking(offering.Id);

            var offeringReadDto = _mapper.Map<ReadOfferingDto>(newOffering);
            _statusCode = (int)Scode.CREATED;

            _viewModel.SetData(offeringReadDto);
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - FF1104A");
        }
        catch (Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - FF1104B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Update(EditOfferingDto offeringEditDto, int id)
    {
        offeringEditDto.Validate();
        if (!offeringEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(offeringEditDto.GetNotification());

            return _viewModel;
        }

        if (await MonthWorkIsBlock(offeringEditDto.Day.ToString(), offeringEditDto.ChurchId))
        {
            _statusCode = (int)Scode.NOT_ACCEPTABLE;
            _viewModel!.SetErrors("This competence has already been closed!");

            return _viewModel;
        }

        try
        {
            var offering = await _context.GetOne(id);
            if (offering == null)
            {
                _statusCode = 404;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            var editOffering = _mapper.Map<Offering>(offeringEditDto);
            offering.UpdateChanges(editOffering);

            await _context.Put(offering);

            _statusCode = (int)Scode.OK;
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - FF1105B");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - FF1105C");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
        try
        {
            var offering = await _context.GetOne(id);
            if (offering == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            if (await MonthWorkIsBlock(offering.Day.ToString(), offering.ChurchId))
            {
                _statusCode = (int)Scode.NOT_ACCEPTABLE;
                _viewModel!.SetErrors("This competence has already been closed!");

                return _viewModel;
            }

            await _context.Delete(offering);

            _statusCode = (int)Scode.OK;
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - FF1106A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - FF1106B");
        }

        return _viewModel;
    }

}
