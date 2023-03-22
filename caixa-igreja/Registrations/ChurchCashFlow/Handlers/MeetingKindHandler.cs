using AutoMapper;
using ChurchCashFlow.Data.ViewModels;
using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Models.Entities;
using DataModelChurchCashFlow.Queries;
using ChurchCashFlow.Data.ViewModels.Dtos.MeetingKind;
using Scode = HttpCodeLib.NumberStatusCode;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ChurchCashFlow.Handlers;
public class MeetingKindHandler : Handler
{
    private IMeetingKindContext _context;
    private IMapper _mapper;

    public MeetingKindHandler(IMeetingKindContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ResultViewModel<IEnumerable<ReadMeetingKindDto>>> GetAll(bool active = true)
    {
        try
        {
            var meetingKindExpression  = Queries<MeetingKind>.GetActive(active);

            var meetingKindQuery = _context.GetAll();
            var meetingKind = await meetingKindQuery.Where(meetingKindExpression).ToListAsync();

            var meetingKindReadDto = _mapper.Map<IEnumerable<ReadMeetingKindDto>>(meetingKind);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<IEnumerable<ReadMeetingKindDto>>(meetingKindReadDto);
        }
        catch(Exception ex)
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
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
                StatusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadMeetingKindDto>("Object not found");
            }

            StatusCode = (int)Scode.OK;

            var meetingKindReadDto = _mapper.Map<ReadMeetingKindDto>(meetingKind);
            return new ResultViewModel<ReadMeetingKindDto>(meetingKindReadDto);
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadMeetingKindDto>("Internal Error - MT1102A");
        }
    }

    public async Task<ResultViewModel<ReadMeetingKindDto>> Create(EditMeetingKindDto meetingKindEditDto)
    {
        meetingKindEditDto.Validate();
        if (!meetingKindEditDto.IsValid)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadMeetingKindDto>(meetingKindEditDto.GetNotification());
        }

        try
        {
            var meetingKind = _mapper.Map<MeetingKind>(meetingKindEditDto);

            await _context.Post(meetingKind)!;

            var newMeeting = await _context.GetOne(meetingKind.Id);

            ReadMeetingKindDto meetingReadDto = _mapper.Map<ReadMeetingKindDto>(newMeeting);
            StatusCode = (int)Scode.CREATED;

            return new ResultViewModel<ReadMeetingKindDto>(meetingReadDto);
        }
        catch (DbUpdateException)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadMeetingKindDto>("Request Error. Check the properties - MT1103A");
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
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
                StatusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadMeetingKindDto>("Object not found");
            }

            await _context.Delete(meetingKind);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<ReadMeetingKindDto>();
        }
        catch (DbException ex)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadMeetingKindDto>("Request Error. Check the properties - MT1104A");
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadMeetingKindDto>("Internal Error - MT1104B");
        }
    }


}