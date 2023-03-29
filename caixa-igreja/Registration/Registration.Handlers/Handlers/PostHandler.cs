using AutoMapper;
using CRegistration.Mapper.DTOs.Post;
using Microsoft.EntityFrameworkCore;
using Registration.DomainBase.ContextAbstraction;
using Registration.DomainBase.Entities;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainCore.ViewModel;
using Registration.Handlers.Queries;
using Registration.Mapper.DTOs.Post;
using System.Data.Common;
using Scode = HttpCodeLib.NumberStatusCode;

namespace ChurchCashFlow.Handlers;
public class PostHandler : IHandler<ReadPostDto, EditPostDto>
{
    private IPostRepository _context;
    private IMapper _mapper;
    private int _statusCode;
    public PostHandler(IPostRepository context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public int GetStatusCode() => (int)_statusCode;

    public async Task<ResultViewModel<IEnumerable<ReadPostDto>>> GetAll(bool active = true)
    {
        try
        {
            var postExpression = Querie<Post>.GetActive(active);

            var postsQuery = _context.GetAll();
            var posts = await postsQuery.Where(postExpression).ToListAsync();

            var postsReadDto = _mapper.Map<IEnumerable<ReadPostDto>>(posts);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<IEnumerable<ReadPostDto>>(postsReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
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
                _statusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadPostDto>("Object not found");
            }

            _statusCode = (int)Scode.OK;

            var postReadDto = _mapper.Map<ReadPostDto>(post);
            return new ResultViewModel<ReadPostDto>(postReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadPostDto>("Internal Error - PS1102A");
        }
    }

    public async Task<ResultViewModel<ReadPostDto>> Create(EditPostDto postEditDto)
    {
        postEditDto.Validate();
        if (!postEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadPostDto>(postEditDto.GetNotification());
        }

        try
        {
            var post = _mapper.Map<Post>(postEditDto);

            await _context.Post(post)!;

            var newPost = await _context.GetOneNoTracking(post.Id);

            ReadPostDto postReadDto = _mapper.Map<ReadPostDto>(newPost);
            _statusCode = (int)Scode.CREATED;

            return new ResultViewModel<ReadPostDto>(postReadDto);
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadPostDto>("Request Error. Check the properties - PS1103A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadPostDto>("Internal Error. - PS1103B");
        }
    }

    public async Task<ResultViewModel<ReadPostDto>> Update(EditPostDto postEditDto, int id)
    {
        postEditDto.Validate();
        if (!postEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadPostDto>(postEditDto.GetNotification());
        }

        try
        {
            var post = await _context.GetOne(id);
            if (post == null)
            {
                _statusCode = 404;
                return new ResultViewModel<ReadPostDto>("Object not found");
            }

            var editPost = _mapper.Map<Post>(postEditDto);
            post.UpdateChanges(editPost);

            await _context.Put(post);

            ReadPostDto postReadDto = _mapper.Map<ReadPostDto>(editPost);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<ReadPostDto>(postReadDto);
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadPostDto>("Request Error. Check the properties - PS1104A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
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
                _statusCode = (int)Scode.NOT_FOUND;
                return new ResultViewModel<ReadPostDto>("Object not found");
            }

            await _context.Delete(user);

            _statusCode = (int)Scode.OK;
            return new ResultViewModel<ReadPostDto>();
        }
        catch (DbException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            return new ResultViewModel<ReadPostDto>("Request Error. Check the properties - PS1105A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            return new ResultViewModel<ReadPostDto>("Internal Error - PS1105B");
        }
    }
}