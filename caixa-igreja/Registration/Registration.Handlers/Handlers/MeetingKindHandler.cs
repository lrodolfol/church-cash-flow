using AutoMapper;
using Scode = HttpCodeLib.NumberStatusCode;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Queries;
using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.MeetingKind;
using Registration.DomainCore.ViewModelAbstraction;

namespace ChurchCashFlow.Handlers;
public class MeetingKindHandler : IHandler<ReadMeetingKindDto, EditMeetingKindDto>
{
    private IMeetingKindRepository _context;
    private IMapper _mapper;
    private int _statusCode;
    private readonly CViewModel _viewModel;

    public MeetingKindHandler(IMeetingKindRepository context, IMapper mapper, CViewModel viewModel)
    {
        _context = context;
        _mapper = mapper;
        _viewModel = viewModel;
    }

    public int GetStatusCode() => (int)_statusCode;

    public async Task<CViewModel> GetAll(bool active = true)
    {
        try
        {
            var meetingKindExpression  = Querie<MeetingKind>.GetActive(active);

            var meetingKindQuery = _context.GetAll();
            var meetingKind = await meetingKindQuery.Where(meetingKindExpression).ToListAsync();

            var meetingKindReadDto = _mapper.Map<IEnumerable<ReadMeetingKindDto>>(meetingKind);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(meetingKindReadDto);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error - MT1101A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        try
        {
            var meetingKind = await _context.GetOneAsNoTracking(id);
            if (meetingKind == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel.SetErrors("Object not found");

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var meetingKindReadDto = _mapper.Map<ReadMeetingKindDto>(meetingKind);
            _viewModel.SetData(meetingKindReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error - MT1102A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditMeetingKindDto meetingKindEditDto)
    {
        meetingKindEditDto.Validate();
        if (!meetingKindEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetErrors(meetingKindEditDto.GetNotification());

            return _viewModel;
        }

        try
        {
            var meetingKind = _mapper.Map<MeetingKind>(meetingKindEditDto);

            await _context.Post(meetingKind)!;

            var newMeeting = await _context.GetOne(meetingKind.Id);

            ReadMeetingKindDto meetingReadDto = _mapper.Map<ReadMeetingKindDto>(newMeeting);
            _statusCode = (int)Scode.CREATED;

            _viewModel.SetData(meetingReadDto);
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetErrors("Request Error. Check the properties - MT1103A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error. - MT1103B");
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
                _viewModel.SetErrors("Object not found");

                return _viewModel;
            }

            await _context.Delete(meetingKind);

            _statusCode = (int)Scode.OK;
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetErrors("Request Error. Check the properties - MT1104A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel.SetErrors("Internal Error - MT1104B");
        }

        return _viewModel;
    }

    public Task<CViewModel> Update(EditMeetingKindDto churchEditDto, int id)
    {
        //Ainda não implementado
        throw new NotImplementedException();
    }
}