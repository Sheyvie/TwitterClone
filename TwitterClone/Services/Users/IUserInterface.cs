using TwitterClone.Models;

namespace TwitterClone.Services.Users
{
    public interface IUserInterface
    {
        Task <List<UserDto>> GetUsersAsync();
        Task <UserDto> GetUserById( Guid id);
    }
}
