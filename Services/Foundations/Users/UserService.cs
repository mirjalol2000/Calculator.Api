using Calculator.Api.Brokers.Storages;
using Calculator.Api.Models.Users;
using System.Security.AccessControl;
<<<<<<< HEAD
using System.Threading.Tasks;
=======
>>>>>>> 18bde343e770de1c858f36429d5089abe2f4b058

namespace Calculator.Api.Services.Foundations.Users
{
    public class UserService : IUserService
    {
        private readonly IStorageBroker storageBroker;

        public UserService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public async ValueTask<User> AddUserAsync(User user) =>
            await this.storageBroker.InsertUserAsync(user);

    }
}
