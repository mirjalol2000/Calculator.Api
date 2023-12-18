using Calculator.Api.Models.Users;
<<<<<<< HEAD
using System.Threading.Tasks;
=======
>>>>>>> 18bde343e770de1c858f36429d5089abe2f4b058

namespace Calculator.Api.Services.Foundations.Users
{
    public interface IUserService
    {
       ValueTask<User> AddUserAsync(User user);
    }
}
