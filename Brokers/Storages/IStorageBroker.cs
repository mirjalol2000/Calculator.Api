using Calculator.Api.Models.Users;

namespace Calculator.Api.Brokers.Storages
{
    public interface IStorageBroker
    {
        ValueTask<User> InsertUserAsync(User user); 
    }
}
