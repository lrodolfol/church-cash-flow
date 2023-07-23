using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Scode = HttpCodeLib.NumberStatusCode;
using System.Data.Common;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Queries;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Tithes;
using Registration.Mapper.DTOs.Registration.Offering;
using System.Linq;

namespace Registration.Handlers.Handlers.Registrations;
public sealed class TithesHanler : BaseRegisterNormalHandler
{
    private ITithesRepository _context;
    private OperationsHandler _operationsHandler;

    public TithesHanler(ITithesRepository context, UserHandler userHandler, IMapper mapper, CViewModel viewModel, OperationsHandler operationsHandler) : base(mapper, viewModel)
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
            _viewModel!.SetErrors("Internal Error - TH1101A");
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
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var outFlowReadDto = _mapper.Map<ReadTithesDto>(tithes);
            _viewModel.SetData(outFlowReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - TH1102A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOneByChurch(int churchId, int id)
    {
        try
        {
            var tithes = await _context.GetOneByChurch(churchId, id);
            if (tithes == null)
            {
                _statusCode = (int)Scode.OK;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var outFlowReadDto = _mapper.Map<ReadTithesDto>(tithes);
            _viewModel.SetData(outFlowReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - TH1102A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetAllByCompetence(int churchId, string yearMonth, bool active = true)
    {
        try
        {
            var competence = $"{yearMonth.Substring(0, 4)}-{yearMonth.Substring(4, 2)}-01";

            if (!ValidateCompetence(competence))
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - TH1103A");

                return _viewModel;
            }

            var tithesExpression = Querie<Tithes>.GetActive(active);

            var tithesQuery = _context.GetAll(churchId);
            var tithes = await tithesQuery
                .Where(tithesExpression)
                .Where(x => x.Day.Year == DateTime.Parse(competence).Year && x.Day.Month == DateTime.Parse(competence).Month)
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
            _viewModel!.SetErrors("Internal Error - TH1103B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetByPeriod(int churchId, string initialDate, string finalDate, bool active)
    {
        try
        {
            if (!ValidateCompetence(initialDate) | !ValidateCompetence(finalDate))
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - TH1104A");

                return _viewModel;
            }

            var tithesExpression = Querie<Tithes>.GetActive(active);

            initialDate = DateTime.Parse(initialDate).ToString("yyyy-MM-dd");
            finalDate = DateTime.Parse(finalDate).ToString("yyyy-MM-dd");

            var tithesQuery = _context.GetAll(churchId);
            var tithes = await tithesQuery
                .Where(tithesExpression)
                .Where(x => x.Day >= DateTime.Parse(initialDate))
                .Where(x => x.Day <= DateTime.Parse(finalDate))
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
            _viewModel!.SetErrors("Internal Error - TH1104B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditTithesDto tithesEditDto)
    {
        tithesEditDto.Validate();
        if (!tithesEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(tithesEditDto.GetNotification());

            return _viewModel;
        }

        if (await MonthWorkIsBlock(tithesEditDto.Competence, tithesEditDto.ChurchId))
        {
            _statusCode = (int)Scode.NOT_ACCEPTABLE;
            _viewModel!.SetErrors("This competence has already been closed!");

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
            _viewModel!.SetErrors("Request Error. Check the properties - TH1105A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - TH1105B");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Update(EditTithesDto tithesEditDto, int id)
    {
        tithesEditDto.Validate();
        if (!tithesEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(tithesEditDto.GetNotification());
        }

        if (await MonthWorkIsBlock(tithesEditDto.Competence, tithesEditDto.ChurchId))
        {
            _statusCode = (int)Scode.NOT_ACCEPTABLE;
            _viewModel!.SetErrors("This competence has already been closed!");

            return _viewModel;
        }

        try
        {
            var tithes = await _context.GetOne(id);
            if (tithes == null)
            {
                _statusCode = 404;
                _viewModel!.SetErrors("Object not found");
            }

            var editTithes = _mapper.Map<Tithes>(tithesEditDto);
            tithes.UpdateChanges(editTithes);

            await _context.Put(tithes);

            _statusCode = (int)Scode.OK;
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - TH1106A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error. - TH1106B");
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
                _viewModel!.SetErrors("Object not found");
            }

            if (await MonthWorkIsBlock(tithes.Competence, tithes.ChurchId))
            {
                _statusCode = (int)Scode.NOT_ACCEPTABLE;
                _viewModel!.SetErrors("This competence has already been closed!");

                return _viewModel;
            }

            await _context.Delete(tithes);

            _statusCode = (int)Scode.OK;
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - TH1107A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetData("Internal Error - TH1107B");
        }

        return _viewModel;
    }


}