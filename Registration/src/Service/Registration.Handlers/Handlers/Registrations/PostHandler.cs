using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Queries;
using System.Data.Common;
using Scode = HttpCodeLib.NumberStatusCode;
using Registration.DomainCore.HandlerAbstraction;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Post;
using Serilog;
using Microsoft.Extensions.Caching.Memory;
using Registration.Mapper.DTOs.Registration.OutFlow;

namespace Registration.Handlers.Handlers.Registrations;
public class PostHandler : BaseRegisterNormalHandler
{
    private IPostRepository _context;
    private readonly ILogger _logger;
    private readonly IMemoryCache _cache;
    private const string _cacheKey = "POSTS";

    private static Dictionary<string, IEnumerable<ReadOutFlowDto>?> HashGetByPeriod = new();

    public PostHandler(IPostRepository context, IMapper mapper, CViewModel viewModel, ILogger logger, IMemoryCache cache)
        : base(mapper, viewModel)
    {
        _context = context;
        _logger = logger;
        _cache = cache;
    }

    public async Task<CViewModel> GetAll(bool active = true)
    {
        IEnumerable<ReadPostDto>? postsReadDto;

        try
        {
            postsReadDto = await _cache.GetOrCreateAsync(_cacheKey, async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeToExpirationCache;

                var postExpression = Querie<Post>.GetActive(active);

                var postsQuery = _context.GetAll();
                var posts = await postsQuery.Where(postExpression).ToListAsync();

                return _mapper.Map<IEnumerable<ReadPostDto>>(posts);
            });

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(postsReadDto);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - PS1101A");
            _logger.Error("Fail get all {error} - PS1101A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        ReadPostDto? postReadDto;

        try
        {
            postReadDto = await _cache.GetOrCreateAsync($"{_cacheKey}-{id}", async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeToExpirationCache;
                var post = await _context.GetOne(id);
                return _mapper.Map<ReadPostDto>(post);
            });
            
            if (postReadDto == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The post with id {id} was not found", id);
                return _viewModel;
            }

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(postReadDto);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - PS1102A");
            _logger.Error("Fail get one {error} - PS1102A", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Create(EditPostDto postEditDto)
    {
        postEditDto.Validate();
        if (!postEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(postEditDto.GetNotification());
            _logger.Error("Invalid propertie. Check the properties");
            return _viewModel;
        }

        try
        {
            var post = _mapper.Map<Post>(postEditDto);

            await _context.Post(post)!;

            var newPost = await _context.GetOneNoTracking(post.Id);

            ReadPostDto postReadDto = _mapper.Map<ReadPostDto>(newPost);

            _statusCode = (int)Scode.CREATED;
            _viewModel.SetData(postReadDto);

            _cache.Remove(_cacheKey);
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - PS1103A");
            _logger.Error("Fail - create {error} - PS1103A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - PS1103B");
            _logger.Error("Fail - create {error} - PS1103B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<CViewModel> Update(EditPostDto postEditDto, int id)
    {
        postEditDto.Validate();
        if (!postEditDto.IsValid)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors(postEditDto.GetNotification());
            _logger.Error("Invalid propertie. Check the properties");
            return _viewModel;
        }

        try
        {
            var post = await _context.GetOne(id);
            if (post == null)
            {
                _statusCode = 404;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The post with id {id} was not found", id);
                return _viewModel;
            }

            var editPost = _mapper.Map<Post>(postEditDto);
            post.UpdateChanges(editPost);

            await _context.Put(post);

            ReadPostDto postReadDto = _mapper.Map<ReadPostDto>(editPost);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(postReadDto);

            _cache.Remove(_cacheKey);
            _cache.Remove($"{_cacheKey}-{postEditDto.Id}");
        }
        catch (DbUpdateException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - PS1104A");
            _logger.Error("Fail - update {error} - PS1104A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - PS1104B");
            _logger.Error("Fail - update {error} - PS1104B", ex.Message);
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
                _logger.Error("The post with id {id} was not found", id);
                return _viewModel;
            }

            await _context.Delete(user);

            _statusCode = (int)Scode.OK;

            _cache.Remove(_cacheKey);
            _cache.Remove($"{_cacheKey}-{id}");
        }
        catch (DbException ex)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - PS1105A");
            _logger.Error("Fail - update {error} - PS1105A", ex.Message);
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - PS1105B");
            _logger.Error("Fail - update {error} - PS1105B", ex.Message);
        }

        return _viewModel;
    }

    public async Task<bool> GetByIds(int[] ids)
    {
        var mPostExpression = Querie<Post>.GetActive(true);
        var mPostQuery = _context.GetByIds(ids);
        var posts = await mPostQuery
            .Where(mPostExpression)
            .ToListAsync();

        return posts.Any();
    }

    protected override Task<bool> MonthWorkIsBlockAsync(string competence, int churchId)
    {
        throw new NotImplementedException();
    }
}