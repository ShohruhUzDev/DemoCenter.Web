using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoCenter.Web.Models.Users;

namespace DemoCenter.Web.Brokers.ApiBrokers
{
    public partial class ApiBroker
    {
        private const string UsersRelativeUrl = "api/users";

        public async ValueTask<User> PostUserAsync(User user) =>
            await PostAsync<User>(UsersRelativeUrl, user);

        public async ValueTask<List<User>> GetAllUsersAsync() =>
            await GetAsync<List<User>>(UsersRelativeUrl);

        public async ValueTask<User> GetUserByIdAsync(Guid userId) =>
            await GetAsync<User>($"{UsersRelativeUrl}/{userId}");

        public async ValueTask<User> PutUserAsync(User user) =>
            await PutAsync<User>(UsersRelativeUrl, user);

        public async ValueTask<User> DeleteUserAsync(Guid userId) =>
            await DeleteAsync<User>($"{UsersRelativeUrl}/{userId}");


    }
}
