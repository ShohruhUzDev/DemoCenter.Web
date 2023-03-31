using DemoCenter.Web.Models.Users;

namespace DemoCenter.Web.Brokers.ApiBrokers
{
    public partial interface IApiBroker
    {
        ValueTask<User> PostUserAsync(User user);
        ValueTask<List<User>> GetAllUsersAsync();
        ValueTask<User> GetUserByIdAsync(Guid userId);
        ValueTask<User> PutUserAsync(User user);
        ValueTask<User > DeleteUserAsync(Guid userId);
    }
}
