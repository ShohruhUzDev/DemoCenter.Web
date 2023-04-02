using System.Collections.Generic;
using System.Threading.Tasks;
using DemoCenter.Web.Models.TeacherViews;

namespace DemoCenter.Web.Services.Views.TeacherViews
{
    public interface ITeacherViewService
    {
        public ValueTask<List<TeacherView>> RetrieveAllTeacherViewsAsync();
    }
}
