using Calculator.Api.Models.Users;
using System.Threading.Tasks;

namespace Calculator.Api.Brokers.Storages
{
    public interface IStorageBroker
    {
        ValueTask<User> InsertUserAsync(User user); 
    }
}
