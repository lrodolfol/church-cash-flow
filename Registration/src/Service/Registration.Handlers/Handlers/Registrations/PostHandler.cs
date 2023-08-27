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

namespace Registration.Handlers.Handlers.Registrations;
public class PostHandler : BaseRegisterNormalHandler
{
    private IPostRepository _context;
    private readonly ILogger _logger;

    public PostHandler(IPostRepository context, IMapper mapper, CViewModel viewModel, ILogger logger) 
        : base(mapper, viewModel)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<CViewModel> GetAll(bool active = true)
    {
        _logger.Information("Post - attemp get all");

        try
        {
            var postExpression = Querie<Post>.GetActive(active);

            var postsQuery = _context.GetAll();
            var posts = await postsQuery.Where(postExpression).ToListAsync();

            var postsReadDto = _mapper.Map<IEnumerable<ReadPostDto>>(posts);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(postsReadDto);

            _logger.Information("{total} post was found", posts.Count);
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
        _logger.Information("Post - attemp get one");

        try
        {
            var post = await _context.GetOne(id);
            if (post == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");
                _logger.Error("The post with id {id} was not found", id);
                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var postReadDto = _mapper.Map<ReadPostDto>(post);
            _viewModel.SetData(postReadDto);

            _logger.Information("outflow was found");
        }
        catch(Exception ex)
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - PS1102A");
            _logger.Error("Fail get one {error} - PS1102A", ex.Message);
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

    public async Task<CViewModel> Create(EditPostDto postEditDto)
    {
        _logger.Information("Post - attemp create");

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

            _logger.Information("Post was successfully created");
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
        _logger.Information("Post - attemp update");

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

            _logger.Information("The post was successfully updated");
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
        _logger.Information("Post - attemp delete one");

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

            _logger.Information("The post was successfully deleted");
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

    protected override Task<bool> MonthWorkIsBlockAsync(string competence, int churchId)
    {
        throw new NotImplementedException();
    }
}