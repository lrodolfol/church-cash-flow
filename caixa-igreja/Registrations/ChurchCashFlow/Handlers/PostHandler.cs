using AutoMapper;
using ChurchCashFlow.Data.ViewModels;
using ChurchCashFlow.Data.ViewModels.Dtos.Post;
using DataModelChurchCashFlow.Context.Interface;
using DataModelChurchCashFlow.Models.Entities;
using DataModelChurchCashFlow.Queries;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Scode = HttpCodeLib.NumberStatusCode;

namespace ChurchCashFlow.Handlers;
public class PostHandler : Handler
{
    private IPostContext _context;
    private IMapper _mapper;

    public PostHandler(IPostContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ResultViewModel<IEnumerable<ReadPostDto>>> GetAll(bool active = true)
    {
        try
        {
            var postExpression = Queries<Post>.GetActive(active);

            var postsQuery = _context.GetAll();
            var posts = await postsQuery.Where(postExpression).ToListAsync();

            var postsReadDto = _mapper.Map<IEnumerable<ReadPostDto>>(posts);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<IEnumerable<ReadPostDto>>(postsReadDto);
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<IEnumerable<ReadPostDto>>("Internal Error - PS1101A");
        }
    }

    public async Task<ResultViewModel<ReadPostDto>> GetOne(int id)
    {
        try
        {
            var post = await _context.GetOne(id);
            if (post == null)
            {
                StatusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadPostDto>("Object not found");
            }

            StatusCode = (int)Scode.OK;

            var postReadDto = _mapper.Map<ReadPostDto>(post);
            return new ResultViewModel<ReadPostDto>(postReadDto);
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadPostDto>("Internal Error - PS1102A");
        }
    }

    public async Task<ResultViewModel<ReadPostDto>> Create(EditPostDto postEditDto)
    {
        postEditDto.Validate();
        if (!postEditDto.IsValid)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadPostDto>(postEditDto.GetNotification());
        }

        try
        {
            var post = _mapper.Map<Post>(postEditDto);

            await _context.Post(post)!;

            var newPost = await _context.GetOneNoTracking(post.Id);

            ReadPostDto postReadDto = _mapper.Map<ReadPostDto>(newPost);
            StatusCode = (int)Scode.CREATED;

            return new ResultViewModel<ReadPostDto>(postReadDto);
        }
        catch (DbUpdateException)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadPostDto>("Request Error. Check the properties - PS1103A");
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadPostDto>("Internal Error. - PS1103B");
        }
    }

    public async Task<ResultViewModel<ReadPostDto>> Update(EditPostDto postEditDto, int id)
    {
        postEditDto.Validate();
        if (!postEditDto.IsValid)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadPostDto>(postEditDto.GetNotification());
        }

        try
        {
            var post = await _context.GetOne(id);
            if (post == null)
            {
                StatusCode = 404;
                return new ResultViewModel<ReadPostDto>("Object not found");
            }

            var editPost = _mapper.Map<Post>(postEditDto);
            post.UpdateChanges(editPost);

            await _context.Put(post);

            ReadPostDto postReadDto = _mapper.Map<ReadPostDto>(editPost);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<ReadPostDto>(postReadDto);
        }
        catch (DbUpdateException)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadPostDto>("Request Error. Check the properties - PS1104A");
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadPostDto>("Internal Error. - PS1104B");
        }
    }

    public async Task<ResultViewModel<ReadPostDto>> Delete(int id)
    {
        try
        {
            var user = await _context.GetOne(id);
            if (user == null)
            {
                StatusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadPostDto>("Object not found");
            }

            await _context.Delete(user);

            StatusCode = (int)Scode.OK;
            return new ResultViewModel<ReadPostDto>();
        }
        catch (DbException)
        {
            StatusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadPostDto>("Request Error. Check the properties - PS1105A");
        }
        catch
        {
            StatusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadPostDto>("Internal Error - PS1105B");
        }
    }
}