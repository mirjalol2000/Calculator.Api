using Calculator.Api.Models.Users;
using System.Threading.Tasks;

namespace Calculator.Api.Services.Foundations.Users
{
    public interface IUserService
    {
       ValueTask<User> AddUserAsync(User user);
    }
}
