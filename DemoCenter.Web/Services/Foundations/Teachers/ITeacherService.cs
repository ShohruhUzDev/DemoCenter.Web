using System.Collections.Generic;
using System.Threading.Tasks;
using DemoCenter.Web.Models.Teachers;

namespace DemoCenter.Web.Services.Foundations.Teachers
{
    public interface ITeacherService
    {
        public ValueTask<List<Teacher>> RetrieveAllTeachersAsync();
    }
}
