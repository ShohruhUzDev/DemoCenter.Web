using DemoCenter.Web.Models.Users;

namespace DemoCenter.Web.Brokers.ApiBrokers
{
    public partial class ApiBroker
    {
        public async ValueTask<List<User>> GetAllUsersAsync() =>
            await GetAsync<List<User>>("api/Users");
    }
}
