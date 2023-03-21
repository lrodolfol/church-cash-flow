using AutoMapper;
using ChurchCashFlow.Data.ViewModels;
using ChurchCashFlow.Data.ViewModels.Dtos.Member;
using ChurchCashFlow.Data.ViewModels.Dtos.User;
using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Models.Entities;
using DataModelChurchCashFlow.Queries;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Scode = HttpCodeLib.NumberStatusCode;

namespace ChurchCashFlow.Handlers;
public class MemberHandler : Handler
{
    private readonly IMemberContext _context;
    private readonly IChurchContext _contextChurch;
    private readonly IPostContext _contextPost;
    private readonly IMapper _mapper;
    public MemberHandler(IMemberContext context, IChurchContext contextChurch, IPostContext contextPost, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
        _contextChurch = contextChurch;
        _contextPost = contextPost;
    }

    public async Task<ResultViewModel<IEnumerable<ReadMemberDto>>> GetAll(bool active = true)
    {
        try
        {
            var memberExpression = Queries<Member>.GetActive(active);

            var membersQuery = _context.GetAllNoTracking();
            var members = await membersQuery.Where(memberExpression).ToListAsync();

            var membersReadDto = _mapper.Map<IEnumerable<ReadMemberDto>>(members);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<IEnumerable<ReadMemberDto>>(membersReadDto);
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
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
                StatusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadMemberDto>("Object not found");
            }

            StatusCode = (int)Scode.OK;

            var memberReadDto = _mapper.Map<ReadMemberDto>(member);
            return new ResultViewModel<ReadMemberDto>(memberReadDto);
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadMemberDto>("Internal Error - MB1102A");
        }
    }

    public async Task<ResultViewModel<ReadMemberDto>> GetByCode(string code)
    {
        try
        {
            var member = await _context.GetByCode(code);
            if (member == null)
            {
                StatusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadMemberDto>("Object not found");
            }

            StatusCode = (int)Scode.OK;

            var memberReadDto = _mapper.Map<ReadMemberDto>(member);
            return new ResultViewModel<ReadMemberDto>(memberReadDto);
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadMemberDto>("Internal Error - MB1103A");
        }
    }

    public async Task<ResultViewModel<ReadMemberDto>> Create(EditMemberDto memberEditDto)
    {
        memberEditDto.Validate();
        if (!memberEditDto.IsValid)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadMemberDto>(memberEditDto.GetNotification());
        }

        try
        {
            var church = await _contextChurch.GetOne(memberEditDto.ChurchId);
            var post = await _contextPost.GetOne(memberEditDto.PostId);

            if(church == null || post == null)
            {
                StatusCode = (int)Scode.BAD_REQUEST;
                return new ResultViewModel<ReadMemberDto>("Request Error. Check the properties - MB1104A");
            }

            var member = _mapper.Map<Member>(memberEditDto);
            member.AddChurch(church);
            member.GenerateCode();

            await _context.Post(member)!;

            var newMember = await _context.GetOneNoTracking(member.Id);

            ReadMemberDto memberReadDto = _mapper.Map<ReadMemberDto>(newMember);
            StatusCode = (int)Scode.CREATED;

            return new ResultViewModel<ReadMemberDto>(memberReadDto);
        }
        catch (DbUpdateException ex)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadMemberDto>("Request Error. Check the properties - MB1104B");
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadMemberDto>("Internal Error. - MB1104C");
        }
    }

    public async Task<ResultViewModel<ReadMemberDto>> Update(EditMemberDto memberEditDto, int id)
    {
        memberEditDto.Validate();
        if (!memberEditDto.IsValid)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadMemberDto>(memberEditDto.GetNotification());
        }

        try
        {
            var member = await _context.GetOne(id);
            if (member == null)
            {
                StatusCode = 404;
                return new ResultViewModel<ReadMemberDto>("Object not found");
            }

            var church = await _contextChurch.GetOne(memberEditDto.ChurchId);
            var post = await _contextPost.GetOne(memberEditDto.PostId);
            if (church == null || post == null)
            {
                StatusCode = (int)Scode.BAD_REQUEST;
                return new ResultViewModel<ReadMemberDto>("Request Error. Check the properties - MB1104A");
            }

            var editMember = _mapper.Map<Member>(memberEditDto);
            member.UpdateChanges(editMember);

            await _context.Put(member);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<ReadMemberDto>();
        }
        catch (DbUpdateException)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadMemberDto>("Request Error. Check the properties - MB1105B");
        }
        catch(Exception ex)
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadMemberDto>("Internal Error. - MB1105C");
        }
    }

    public async Task<ResultViewModel<ReadUserDto>> Delete(int id)
    {
        try
        {
            var user = await _context.GetOne(id);
            if (user == null)
            {
                StatusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadUserDto>("Object not found");
            }

            await _context.Delete(user);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<ReadUserDto>();
        }
        catch (DbException)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadUserDto>("Request Error. Check the properties - MB1106A");
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadUserDto>("Internal Error - MB1106B");
        }
    }
}