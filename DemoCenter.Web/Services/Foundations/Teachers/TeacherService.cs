using System.Collections.Generic;
using System.Threading.Tasks;
using DemoCenter.Web.Brokers.ApiBrokers;
using DemoCenter.Web.Models.Teachers;

namespace DemoCenter.Web.Services.Foundations.Teachers
{
    public class TeacherService :ITeacherService
    {
        private readonly IApiBroker apiBroker;

        public TeacherService(IApiBroker apiBroker) =>
            this.apiBroker = apiBroker;
        

        public async ValueTask<List<Teacher>> RetrieveAllTeachersAsync() =>
            await apiBroker.GetAllTeachersAsync();
    }
}
