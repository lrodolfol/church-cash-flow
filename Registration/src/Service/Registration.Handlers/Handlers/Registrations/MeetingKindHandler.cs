using AutoMapper;
using Scode = HttpCodeLib.NumberStatusCode;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Queries;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.MeetingKind;
using Serilog;
using Microsoft.Extensions.Caching.Memory;

namespace Registration.Handlers.Handlers.Registrations;
public class MeetingKindHandler : BaseNormalHandler
{
    private IMeetingKindRepository _context;
    private ILogger _logger; private readonly IMemoryCache _cache;
    private const string _cacheKey = "MEETINGKIND";

    public MeetingKindHandler(IMeetingKindRepository context, IMapper mapper, CViewModel viewModel, ILogger logger, IMemoryCache cache)
        : base(mapper, viewModel)
    {
        _context = context;
        _logger = logger;
        _cache = cache;
    }

    public async Task<CViewModel> GetAll(bool active = true)
    {
        IEnumerable<ReadMeetingKindDto>? meetingKindReadDto;

        try
        {
            meetingKindReadDto = await _cache.GetOrCreateAsync(_cacheKey, async entry =>
            {
                var meetingKindExpression = Querie<MeetingKind>.GetActive(active);

                var meetingKindQuery = _context.GetAll();
                var meetingKind = await meetingKindQuery!.Where(meetingKindExpression).ToListAsync();

                return _mapper.Map<IEnumerable<ReadMeetingKindDto>>(meetingKind);
            });

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(meetingKindReadDto);
        }
        catch (Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MT1101A");
            _logger.Error("Fail - get all meetingKind - MT1101A {error}", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        ReadMeetingKindDto? meetingKindReadDto;
        MeetingKind? meetingKind = null;
        try
        {
            meetingKindReadDto = await _cache.GetOrCreateAsync($"{_cacheKey}-{id}", async entry =>
            {
                meetingKind = await _context.GetOneAsNoTracking(id);
                return _mapper.Map<ReadMeetingKindDto>(meetingKind);
            });

            if (meetingKindReadDto == null)
            {
                _statusCode = (int)Scode.OK;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The meetingkind with id {id} was not found", id);

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            _viewModel.SetData(meetingKindReadDto);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MT1102A");
            _logger.Error("Fail - get one meetingKind - MT1102A - {error}", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditMeetingKindDto dto)
    {
        dto.Validate();
        if (!ValidateCreateEdit(dto))
            return _viewModel;

        try
        {
            var meetingKind = _mapper.Map<MeetingKind>(dto);

            await _context.Post(meetingKind)!;

            var newMeeting = await _context.GetOne(meetingKind.Id);

            ReadMeetingKindDto meetingReadDto = _mapper.Map<ReadMeetingKindDto>(newMeeting);
            _statusCode = (int)Scode.CREATED;

            _viewModel.SetData(meetingReadDto);
            _cache.Remove(_cacheKey);
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - MT1103A");
            _logger.Error("Fail. create meeting kind = MT1103A - {error}", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - MT1103B");
            _logger.Error("Fail. create meeting kind = MT1103B - {error}", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
        try
        {
            var meetingKind = await _context.GetOne(id);
            if (meetingKind == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The meetingkind with id {id} was not found", id);

                return _viewModel;
            }

            await _context.Delete(meetingKind);

            _statusCode = (int)Scode.OK;
            _cache.Remove($"{_cacheKey}-{id}");
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - MT1104A");
            _logger.Error("Fail. delete meeting kind - MT1104A - {error}", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MT1104B");
            _logger.Error("Fail. delete meeting kind - MT1104B - {error}", ex.Message);
        }

        return _viewModel;
    }

    private bool ValidateCreateEdit(EditMeetingKindDto dto)
    {
        if (!dto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(dto.GetNotification());
            _logger.Information("Invalid properties, check the properties");

            return false;
        }

        return true;
    }
}