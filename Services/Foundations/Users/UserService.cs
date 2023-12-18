using Calculator.Api.Brokers.Storages;
using Calculator.Api.Models.Users;
using System.Security.AccessControl;
using System.Threading.Tasks;

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
