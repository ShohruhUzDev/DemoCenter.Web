using System.Collections.Generic;
using System.Threading.Tasks;
using DemoCenter.Web.Models.Users;
using DemoCenter.Web.Models.UserViews;

namespace DemoCenter.Web.Services.Views.UserViews
{
    public interface IUserViewService
    {
        ValueTask<List<UserView>> RetrieveUserViewsAsync();
    }
}
