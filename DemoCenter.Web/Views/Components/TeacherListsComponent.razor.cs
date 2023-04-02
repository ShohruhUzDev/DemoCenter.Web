using System.Collections.Generic;
using DemoCenter.Web.Models.States;
using DemoCenter.Web.Models.TeacherViews;
using DemoCenter.Web.Services.Views.TeacherViews;
using Microsoft.AspNetCore.Components;

namespace DemoCenter.Web.Views.Components
{
    public partial class TeacherListsComponent
    {
        [Inject]
        public ITeacherViewService TeacherViewService { get; set; }

        public State CurrentState { get; set; }

        public List<TeacherView> TeacherViews { get; set; }

        protected override async void OnInitialized()
        {
            try
            {
                TeacherViews = await TeacherViewService.RetrieveAllTeacherViewsAsync();
                CurrentState = State.Content;

            }
            catch (System.Exception)
            {
                CurrentState = State.Error;
            }
            StateHasChanged();
        }
    }
}