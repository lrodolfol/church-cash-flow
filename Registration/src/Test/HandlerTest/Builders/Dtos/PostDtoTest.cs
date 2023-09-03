using HandlersTest.Builders.Dto;
using HandlersTest.Builders.Entities;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.Post;

namespace HandlersTest.Builders.Dtos;

public class PostDtoTest
{
    public static EditPostDto ValidObjectOne()
    {
        var post = PostTest.ValidObjectOne();
        var editDto = ConvertEditPostDo(post);

        return editDto;
    }

    public static EditPostDto ValidObjectTwo()
    {
        var post = PostTest.ValidObjectTwo();
        var editDto = ConvertEditPostDo(post);

        return editDto;
    }

    public static EditPostDto InvalidObjectOne()
    {
        var post = PostTest.InvalidObjectOne();
        var editDto = ConvertEditPostDo(post);

        return editDto;
    }

    public static EditPostDto InvalidObjectTwo()
    {
        var post = PostTest.InvalidObjectTwo();
        var editDto = ConvertEditPostDo(post);

        return editDto;
    }

    private static EditPostDto ConvertEditPostDo(Post post) =>
        new EditPostDto() { Name = post.Name, Description = post.Description };
}