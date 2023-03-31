using DemoCenter.Web.Brokers.DateTimes;
using DemoCenter.Web.Brokers.Loggings;
using DemoCenter.Web.Models.Users;
using DemoCenter.Web.Models.UserViews;
using DemoCenter.Web.Services.Foundations.Users;

namespace DemoCenter.Web.Services.Views.UserViews
{
    public class UserViewService : IUserViewService
    {
        private readonly IUserService userService;
        private readonly IDateTimeBroker dateTimeBroker;
        private readonly ILoggingBroker loggingBroker;

        public UserViewService(
            IUserService userService,
            IDateTimeBroker dateTimeBroker, 
            ILoggingBroker loggingBroker)
        {
            this.userService = userService;
            this.dateTimeBroker = dateTimeBroker;
            this.loggingBroker = loggingBroker;
        }


        public async ValueTask<List<UserView>> RetrieveUserViewsAsync()
        {
            List<User> users = await this.userService.RetrieveAllUsersAsync();

            return users.Select(AsUserView).ToList();
        }

        private static Func<User, UserView> AsUserView =>
            user => new UserView
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                BirthDate = user.BirthDate,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Password = user.Password
            };
    }
}
