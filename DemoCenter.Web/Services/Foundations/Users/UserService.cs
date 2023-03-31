using DemoCenter.Web.Brokers.ApiBrokers;
using DemoCenter.Web.Models.Users;

namespace DemoCenter.Web.Services.Foundations.Users
{
    public class UserService : IUserService
    {
        private readonly IApiBroker apiBroker;

        public UserService(IApiBroker apiBroker) =>
            this.apiBroker = apiBroker;

        public async ValueTask<List<User>> RetrieveAllUsersAsync() =>
            await this.apiBroker.GetAllUsersAsync();

    }
}
