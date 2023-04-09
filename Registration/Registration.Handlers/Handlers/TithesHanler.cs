﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Scode = HttpCodeLib.NumberStatusCode;
using System.Data.Common;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Queries;
using Registration.DomainBase.Entities;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.Tithes;
using Registration.DomainCore.HandlerAbstraction;

namespace Registration.Handlers.Handlers;
public class TithesHanler : Handler
{
    private ITithesRepository _context;
    
    public TithesHanler(ITithesRepository context, UserHandler userHandler, IMapper mapper, CViewModel viewModel) : base(mapper, viewModel)
    {
        _context = context;
    }

    public async Task<CViewModel> GetAll(int churchId, bool active = true)
    {
        try
        {
            var tithesExpression = Querie<Tithes>.GetActive(active);

            var outFlowQuery = _context.GetAll(churchId);
            var tithes = await outFlowQuery
                .Where(tithesExpression)
                .Include(x => x.Member)
                .Include(x => x.OfferingKind)
                .Include(x => x.Church)
                .ToListAsync();

            var tithesReadDto = _mapper.Map<IEnumerable<ReadTithesDto>>(tithes);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(tithesReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error - TH1101A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        try
        {
            var tithes = await _context.GetOne(id);
            if (tithes == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel.SetErrors("Object not found");

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var outFlowReadDto = _mapper.Map<ReadTithesDto>(tithes);
            _viewModel.SetData(outFlowReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error - TH1102A");
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
                _viewModel.SetErrors("Request Error. Check the properties - TH1103A");

                return _viewModel;
            }

            var tithesExpression = Querie<Tithes>.GetActive(active);

            var tithesQuery = _context.GetAll(churchId);
            var tithes = await tithesQuery
                .Where(tithesExpression)
                .Where(x => x.Competence == DateTime.Parse(competence).ToString("MM/yyyy"))
                .Include(x => x.Church)
                .Include(x => x.OfferingKind)
                .Include(x => x.Member)
                .ToListAsync();

            var tithesReadDto = _mapper.Map<IEnumerable<ReadTithesDto>>(tithes);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(tithesReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error - TH1103B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditTithesDto tithesEditDto)
    {
        tithesEditDto.Validate();
        if (!tithesEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetErrors(tithesEditDto.GetNotification());

            return _viewModel;
        }

        try
        {
            var tithes = _mapper.Map<Tithes>(tithesEditDto);
            await _context.Post(tithes)!;

            var newTithes = await _context.GetOne(tithes.Id);

            var tithesReadDto = _mapper.Map<ReadTithesDto>(newTithes);
            _statusCode = (int)Scode.CREATED;

            _viewModel.SetData(tithesReadDto);
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetErrors("Request Error. Check the properties - TH1104A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error. - TH1104B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Update(EditTithesDto tithesEditDto, int id)
    {
        tithesEditDto.Validate();
        if (!tithesEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetErrors(tithesEditDto.GetNotification());
        }

        try
        {
            var tithes = await _context.GetOne(id);
            if (tithes == null)
            {
                _statusCode = 404;
                _viewModel.SetErrors("Object not found");
            }

            var editTithes = _mapper.Map<Tithes>(tithesEditDto);
            tithes.UpdateChanges(editTithes);
            
            await _context.Put(tithes);

            _statusCode = (int)Scode.OK;
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - TH1105A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error. - TH1105B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
        try
        {
            var tithes = await _context.GetOne(id);
            if (tithes == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel.SetErrors("Object not found");
            }

            await _context.Delete(tithes);

            _statusCode = (int)Scode.OK;
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - TH1106A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error - TH1106B");
        }

        return _viewModel;
    }
        
}