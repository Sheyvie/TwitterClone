using TwitterClone.Models;

namespace TwitterClone.Services.Posts
{
    public interface IPostInterface
    {
        Task<List<PostDto>> GetPostsAsync();
        Task<PostDto> GetPostById(Guid id);
    }
}
