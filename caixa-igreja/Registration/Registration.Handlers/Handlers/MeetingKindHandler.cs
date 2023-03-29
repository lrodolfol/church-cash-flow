using AutoMapper;
using Scode = HttpCodeLib.NumberStatusCode;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.ContextAbstraction;
using Registration.DomainCore.ViewModel;
using Registration.Handlers.Queries;
using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.MeetingKind;

namespace ChurchCashFlow.Handlers;
public class MeetingKindHandler : IHandler<ReadMeetingKindDto, EditMeetingKindDto>
{
    private IMeetingKindRepository _context;
    private IMapper _mapper;
    private int _statusCode;

    public MeetingKindHandler(IMeetingKindRepository context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public int GetStatusCode() => (int)_statusCode;

    public async Task<ResultViewModel<IEnumerable<ReadMeetingKindDto>>> GetAll(bool active = true)
    {
        try
        {
            var meetingKindExpression  = Querie<MeetingKind>.GetActive(active);

            var meetingKindQuery = _context.GetAll();
            var meetingKind = await meetingKindQuery.Where(meetingKindExpression).ToListAsync();

            var meetingKindReadDto = _mapper.Map<IEnumerable<ReadMeetingKindDto>>(meetingKind);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<IEnumerable<ReadMeetingKindDto>>(meetingKindReadDto);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<IEnumerable<ReadMeetingKindDto>>("Internal Error - MT1101A");
        }
    }

    public async Task<ResultViewModel<ReadMeetingKindDto>> GetOne(int id)
    {
        try
        {
            var meetingKind = await _context.GetOneAsNoTracking(id);
            if (meetingKind == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadMeetingKindDto>("Object not found");
            }

            _statusCode = (int)Scode.OK;

            var meetingKindReadDto = _mapper.Map<ReadMeetingKindDto>(meetingKind);
            return new ResultViewModel<ReadMeetingKindDto>(meetingKindReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadMeetingKindDto>("Internal Error - MT1102A");
        }
    }

    public async Task<ResultViewModel<ReadMeetingKindDto>> Create(EditMeetingKindDto meetingKindEditDto)
    {
        meetingKindEditDto.Validate();
        if (!meetingKindEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadMeetingKindDto>(meetingKindEditDto.GetNotification());
        }

        try
        {
            var meetingKind = _mapper.Map<MeetingKind>(meetingKindEditDto);

            await _context.Post(meetingKind)!;

            var newMeeting = await _context.GetOne(meetingKind.Id);

            ReadMeetingKindDto meetingReadDto = _mapper.Map<ReadMeetingKindDto>(newMeeting);
            _statusCode = (int)Scode.CREATED;

            return new ResultViewModel<ReadMeetingKindDto>(meetingReadDto);
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadMeetingKindDto>("Request Error. Check the properties - MT1103A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadMeetingKindDto>("Internal Error. - MT1103B");
        }
    }

    public async Task<ResultViewModel<ReadMeetingKindDto>> Delete(int id)
    {
        try
        {
            var meetingKind = await _context.GetOne(id);
            if (meetingKind == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadMeetingKindDto>("Object not found");
            }

            await _context.Delete(meetingKind);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<ReadMeetingKindDto>();
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadMeetingKindDto>("Request Error. Check the properties - MT1104A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadMeetingKindDto>("Internal Error - MT1104B");
        }
    }

    public Task<ResultViewModel<ReadMeetingKindDto>> Update(EditMeetingKindDto churchEditDto, int id)
    {
        //Ainda não implementado
        throw new NotImplementedException();
    }
}