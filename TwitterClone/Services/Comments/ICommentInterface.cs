using TwitterClone.Models;

namespace TwitterClone.Services.Comments
{
    public interface ICommentInterface
    {
        Task<List<CommentDto>> GetCommentsAsync();
        Task<CommentDto> GetCommentById(Guid id);
    }
}
