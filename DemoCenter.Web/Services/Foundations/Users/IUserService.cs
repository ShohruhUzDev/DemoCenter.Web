using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoCenter.Web.Models.Users;

namespace DemoCenter.Web.Services.Foundations.Users
{
    public interface IUserService
    {
        public ValueTask<List<User>> RetrieveAllUsersAsync();
        public ValueTask<User> RemoveUserByIdAsync(Guid userId);
    }
}
