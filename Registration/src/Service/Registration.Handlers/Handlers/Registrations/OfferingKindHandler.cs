using AutoMapper;
using Scode = HttpCodeLib.NumberStatusCode;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Queries;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.OfferingKind;
using Serilog;

namespace Registration.Handlers.Handlers.Registrations;
public class OfferingKindHandler : BaseNormalHandler
{
    private IOfferingKindRepository _context;
    private ILogger _logger;

    public OfferingKindHandler(IOfferingKindRepository context, IMapper mapper, CViewModel viewModel, ILogger logger) 
        : base(mapper, viewModel)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<CViewModel> GetAll(bool active = true)
    {
        _logger.Information("Offering kind - attemp get all");

        try
        {
            var offeringKindExpression = Querie<OfferingKind>.GetActive(active);

            var offeringKindQuery = _context.GetAll();
            var offeringKind = await offeringKindQuery.Where(offeringKindExpression).ToListAsync();

            var offeringKindReadDto = _mapper.Map<IEnumerable<ReadOfferingKindDto>>(offeringKind);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(offeringKindReadDto);

            _logger.Information("{total} was found {kid}", offeringKind.Select(x => x.Name));
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - OF101A");
            _logger.Error("Fail - get all {error} - OF101A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        _logger.Information("Offering kind - attemp get one");

        try
        {
            var offeringKind = await _context.GetOneAsNoTracking(id);
            if (offeringKind == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var OfferingKindReadDto = _mapper.Map<ReadOfferingKindDto>(offeringKind);
            _viewModel.SetData(OfferingKindReadDto);

            _logger.Information("offering kind {name} was found", offeringKind.Name);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - OF102A");
            _logger.Error("Fail - get all {error} - OF102A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditOfferingKindDto OfferingKindEditDto)
    {
        _logger.Information("Offering kind - attemp create");

        OfferingKindEditDto.Validate();
        if (!OfferingKindEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(OfferingKindEditDto.GetNotification());
            _logger.Error("Invalid properties. Check the properties");
            return _viewModel;
        }

        try
        {
            var OfferingKind = _mapper.Map<OfferingKind>(OfferingKindEditDto);

            await _context.Post(OfferingKind)!;

            var newOffering = await _context.GetOne(OfferingKind.Id);

            ReadOfferingKindDto offeringReadDto = _mapper.Map<ReadOfferingKindDto>(newOffering);
            _statusCode = (int)Scode.CREATED;

            _viewModel.SetData(offeringReadDto);

            _logger.Information("The kind was sussccessfully created");
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - OF103A");
            _logger.Error("Fail - create one {error} - OF103A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - OF103B");
            _logger.Error("Fail - create one {error} - OF103B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
        _logger.Information("Offering kind attemp delete");

        try
        {
            var OfferingKind = await _context.GetOne(id);
            if (OfferingKind == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The kind with id {id} was not found", id);
                return _viewModel;
            }

            await _context.Delete(OfferingKind);

            _statusCode = (int)Scode.OK;
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - OF104A");
            _logger.Error("Failt delete one {error} - OF104A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - OF104B");
            _logger.Error("Failt delete one {error} - OF104B", ex.Message);
        }

        return _viewModel;
    }

}