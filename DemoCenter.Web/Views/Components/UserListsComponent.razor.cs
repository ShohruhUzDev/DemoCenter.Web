using DemoCenter.Web.Models.States;
using DemoCenter.Web.Models.Users;
using DemoCenter.Web.Models.UserViews;
using DemoCenter.Web.Services.Foundations.Users;
using DemoCenter.Web.Services.Views.UserViews;
using Microsoft.AspNetCore.Components;

namespace DemoCenter.Web.Views.Components
{
    public partial class UserListsComponent
    {
        [Inject]
        public IUserViewService UserViewService { get; set; }   

        public State CurrentState { get; set; }
        public List<UserView> UserViews { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                this.UserViews=await this.UserViewService.RetrieveUserViewsAsync();
                this.CurrentState = State.Content;
            }
            catch (Exception exception)
            {
                this.CurrentState= State.Error;
            }

            StateHasChanged();
        }
    }
}