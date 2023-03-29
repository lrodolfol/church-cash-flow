using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Scode = HttpCodeLib.NumberStatusCode;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.ContextAbstraction;
using Registration.DomainCore.ViewModel;
using Registration.Handlers.Queries;
using Registration.DomainBase.Entities;
using Registration.Mapper.DTOs.Member;
using Microsoft.AspNetCore.Http;

namespace ChurchCashFlow.Handlers;
public class MemberHandler : IHandlerMember<ReadMemberDto, EditMemberDto>
{
    private readonly IMemberRepository _context;
    private readonly IChurchRepository _contextChurch;
    private readonly IPostRepository _contextPost;
    private readonly IMapper _mapper;
    private int _statusCode;

    public MemberHandler(IMemberRepository context, 
        IChurchRepository contextChurch, 
        IPostRepository contextPost, 
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
        _contextChurch = contextChurch;
        _contextPost = contextPost;
    }

    public int GetStatusCode() => (int)_statusCode;

    public async Task<ResultViewModel<IEnumerable<ReadMemberDto>>> GetAll(bool active = true)
    {
        try
        {
            var memberExpression = Querie<Member>.GetActive(active);

            var membersQuery = _context.GetAllNoTracking();
            var members = await membersQuery.Where(memberExpression).ToListAsync();

            var membersReadDto = _mapper.Map<IEnumerable<ReadMemberDto>>(members);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<IEnumerable<ReadMemberDto>>(membersReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<IEnumerable<ReadMemberDto>>("Internal Error - MB1101A");
        }
    }

    public async Task<ResultViewModel<ReadMemberDto>> GetOne(int id)
    {
        try
        {
            var member = await _context.GetOne(id);
            if (member == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadMemberDto>("Object not found");
            }

            _statusCode = (int)Scode.OK;

            var memberReadDto = _mapper.Map<ReadMemberDto>(member);
            return new ResultViewModel<ReadMemberDto>(memberReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadMemberDto>("Internal Error - MB1102A");
        }
    }

    public async Task<ResultViewModel<ReadMemberDto>> GetByCode(string userCode)
    {
        try
        {
            var member = await _context.GetByCode(userCode);
            if (member == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadMemberDto>("Object not found");
            }

            _statusCode = (int)Scode.OK;

            var memberReadDto = _mapper.Map<ReadMemberDto>(member);
            return new ResultViewModel<ReadMemberDto>(memberReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadMemberDto>("Internal Error - MB1103A");
        }
    }

    public async Task<ResultViewModel<ReadMemberDto>> Create(EditMemberDto memberEditDto)
    {
        memberEditDto.Validate();
        if (!memberEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadMemberDto>(memberEditDto.GetNotification());
        }

        try
        {
            var church = await _contextChurch.GetOne(memberEditDto.ChurchId);
            var post = await _contextPost.GetOne(memberEditDto.PostId);

            if(church == null || post == null)
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                return new ResultViewModel<ReadMemberDto>("Request Error. Check the properties - MB1104A");
            }

            var member = _mapper.Map<Member>(memberEditDto);
            member.AddChurch(church);
            member.GenerateCode();

            await _context.Post(member)!;

            var newMember = await _context.GetOneNoTracking(member.Id);

            ReadMemberDto memberReadDto = _mapper.Map<ReadMemberDto>(newMember);
            _statusCode = (int)Scode.CREATED;

            return new ResultViewModel<ReadMemberDto>(memberReadDto);
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadMemberDto>("Request Error. Check the properties - MB1104B");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadMemberDto>("Internal Error. - MB1104C");
        }
    }

    public async Task<ResultViewModel<ReadMemberDto>> Update(EditMemberDto memberEditDto, int id)
    {
        memberEditDto.Validate();
        if (!memberEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadMemberDto>(memberEditDto.GetNotification());
        }

        try
        {
            var member = await _context.GetOne(id);
            if (member == null)
            {
                _statusCode = 404;
                return new ResultViewModel<ReadMemberDto>("Object not found");
            }

            var church = await _contextChurch.GetOne(memberEditDto.ChurchId);
            var post = await _contextPost.GetOne(memberEditDto.PostId);
            if (church == null || post == null)
            {
                _statusCode = (int)Scode.BAD_REQUEST;
                return new ResultViewModel<ReadMemberDto>("Request Error. Check the properties - MB1104A");
            }

            var editMember = _mapper.Map<Member>(memberEditDto);
            member.UpdateChanges(editMember);

            await _context.Put(member);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<ReadMemberDto>();
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadMemberDto>("Request Error. Check the properties - MB1105B");
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadMemberDto>("Internal Error. - MB1105C");
        }
    }

    public async Task<ResultViewModel<ReadMemberDto>> Delete(int id)
    {
        try
        {
            var user = await _context.GetOne(id);
            if (user == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadMemberDto>("Object not found");
            }

            await _context.Delete(user);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<ReadMemberDto>();
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadMemberDto>("Request Error. Check the properties - MB1106A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadMemberDto>("Internal Error - MB1106B");
        }
    }
}