using Registration.DomainCore.ViewModelAbstraction;
using Registration.Mapper.DTOs.Registration.Post;

namespace Registration.Handlers.Handlers.Abstraction;
public interface IPostHandler
{
    Task<CViewModel> GetAll(bool active = true);
    Task<CViewModel> GetOne(int id);
    Task<CViewModel> Create(EditPostDto postEditDto);
    Task<CViewModel> Update(EditPostDto postEditDto, int id);
    Task<CViewModel> Delete(int id);
    Task<bool> GetByIds(int[] ids);

}
