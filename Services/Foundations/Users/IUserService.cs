using Calculator.Api.Models.Users;

namespace Calculator.Api.Services.Foundations.Users
{
    public interface IUserService
    {
       ValueTask<User> AddUserAsync(User user);
    }
}
