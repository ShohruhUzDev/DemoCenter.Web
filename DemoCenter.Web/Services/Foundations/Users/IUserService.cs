using DemoCenter.Web.Models.Users;

namespace DemoCenter.Web.Services.Foundations.Users
{
    public interface IUserService
    {
        public ValueTask<List<User>> RetrieveAllUsersAsync();
    }
}
