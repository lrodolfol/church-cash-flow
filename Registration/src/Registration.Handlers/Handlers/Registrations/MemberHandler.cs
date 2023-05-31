using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Scode = HttpCodeLib.NumberStatusCode;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Queries;
using Registration.Mapper.DTOs.Member;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.Entities.Registrations;

namespace Registration.Handlers.Handlers.Registrations;
public sealed class MemberHandler : BaseRegisterNormalHandler
{
    private readonly IMemberRepository _context;
    private readonly IChurchRepository _contextChurch;
    private readonly IPostRepository _contextPost;
    private OperationsHandler _operationsHandler;

    public MemberHandler(IMemberRepository context,
        IChurchRepository contextChurch,
        IPostRepository contextPost,
        IMapper mapper,
        CViewModel viewModel,
        OperationsHandler operationsHandler) : base(mapper, viewModel)
    {
        _context = context;
        _contextChurch = contextChurch;
        _contextPost = contextPost;
        _operationsHandler = operationsHandler;
    }

    protected override async Task<bool> MonthWorkIsBlock(string competence, int churchId)
    {
        var yearMonth = DateTime.Parse(competence).ToString("yyyyMM");
        var monthWork = await _operationsHandler.GetOneByCompetence(yearMonth, churchId);

        return monthWork == null ? false : true;
    }

    public async Task<CViewModel> GetAll(bool active = true)
    {
        try
        {
            var memberExpression = Querie<Member>.GetActive(active);

            var membersQuery = _context.GetAllNoTracking();
            var members = await membersQuery.Where(memberExpression).ToListAsync();

            var membersReadDto = _mapper.Map<IEnumerable<ReadMemberDto>>(members);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(membersReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MB1101A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        try
        {
            var member = await _context.GetOne(id);
            if (member == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var memberReadDto = _mapper.Map<ReadMemberDto>(member);
            _viewModel.SetData(memberReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MB1102A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetByCode(string userCode)
    {
        try
        {
            var member = await _context.GetByCode(userCode);
            if (member == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var memberReadDto = _mapper.Map<ReadMemberDto>(member);
            _viewModel.SetData(memberReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MB1103A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditMemberDto memberEditDto)
    {
        memberEditDto.Validate();
        if (!memberEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(memberEditDto.GetNotification());

            return _viewModel;
        }

        try
        {
            var church = await _contextChurch.GetOne(memberEditDto.ChurchId);
            var post = await _contextPost.GetOne(memberEditDto.PostId);

            if (church == null || post == null)
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - MB1104A");
            }

            var member = _mapper.Map<Member>(memberEditDto);
            member.AddChurch(church);
            member.GenerateCode();

            await _context.Post(member)!;

            var newMember = await _context.GetOneNoTracking(member.Id);

            ReadMemberDto memberReadDto = _mapper.Map<ReadMemberDto>(newMember);
            _statusCode = (int)Scode.CREATED;

            _viewModel.SetData(memberReadDto);
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - MB1104B");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - MB1104C");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Update(EditMemberDto memberEditDto, int id)
    {
        memberEditDto.Validate();
        if (!memberEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(memberEditDto.GetNotification());

            return _viewModel;
        }

        try
        {
            var member = await _context.GetOne(id);
            if (member == null)
            {
                _statusCode = 404;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            var church = await _contextChurch.GetOne(memberEditDto.ChurchId);
            var post = await _contextPost.GetOne(memberEditDto.PostId);
            if (church == null || post == null)
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                _viewModel!.SetErrors("Request Error. Check the properties - MB1104A");

                return _viewModel;
            }

            var editMember = _mapper.Map<Member>(memberEditDto);
            member.UpdateChanges(editMember);

            await _context.Put(member);

            _statusCode = (int)Scode.OK;
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - MB1105B");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - MB1105C");
        }

        return _viewModel;
    }

    public async Task<CViewModel> Delete(int id)
    {
        try
        {
            var user = await _context.GetOne(id);
            if (user == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            await _context.Delete(user);

            _statusCode = (int)Scode.OK;
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel.SetData("Request Error. Check the properties - MB1106A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - MB1106B");
        }

        return _viewModel;
    }
}