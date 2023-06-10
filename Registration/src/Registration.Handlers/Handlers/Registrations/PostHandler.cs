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

namespace Registration.Handlers.Handlers.Registrations;
public class PostHandler : BaseRegisterNormalHandler
{
    private IPostRepository _context;
    public PostHandler(IPostRepository context, IMapper mapper, CViewModel viewModel) : base(mapper, viewModel)
    {
        _context = context;
    }

    public async Task<CViewModel> GetAll(bool active = true)
    {
        try
        {
            var postExpression = Querie<Post>.GetActive(active);

            var postsQuery = _context.GetAll();
            var posts = await postsQuery.Where(postExpression).ToListAsync();

            var postsReadDto = _mapper.Map<IEnumerable<ReadPostDto>>(posts);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(postsReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - PS1101A");
        }

        return _viewModel;
    }

    public async Task<CViewModel> GetOne(int id)
    {
        try
        {
            var post = await _context.GetOne(id);
            if (post == null)
            {
                _statusCode = (int)Scode.NOT_FOUND;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            _statusCode = (int)Scode.OK;

            var postReadDto = _mapper.Map<ReadPostDto>(post);
            _viewModel.SetData(postReadDto);
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - PS1102A");
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
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - PS1103A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - PS1103B");
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

            return _viewModel;
        }

        try
        {
            var post = await _context.GetOne(id);
            if (post == null)
            {
                _statusCode = 404;
                _viewModel!.SetErrors("Object not found");

                return _viewModel;
            }

            var editPost = _mapper.Map<Post>(postEditDto);
            post.UpdateChanges(editPost);

            await _context.Put(post);

            ReadPostDto postReadDto = _mapper.Map<ReadPostDto>(editPost);

            _statusCode = (int)Scode.OK;
            _viewModel.SetData(postReadDto);
        }
        catch (DbUpdateException)
        {
            _statusCode = (int)Scode.BAD_REQUEST;
            _viewModel!.SetErrors("Request Error. Check the properties - PS1104A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error. - PS1104B");
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
            _viewModel!.SetErrors("Request Error. Check the properties - PS1105A");
        }
        catch
        {
            _statusCode = (int)Scode.INTERNAL_SERVER_ERROR;
            _viewModel!.SetErrors("Internal Error - PS1105B");
        }

        return _viewModel;
    }

    protected override Task<bool> MonthWorkIsBlock(string competence, int churchId)
    {
        throw new NotImplementedException();
    }
}