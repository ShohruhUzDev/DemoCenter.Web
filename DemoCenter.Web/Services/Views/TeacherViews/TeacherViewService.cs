using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoCenter.Web.Brokers.DateTimes;
using DemoCenter.Web.Brokers.Loggings;
using DemoCenter.Web.Models.Teachers;
using DemoCenter.Web.Models.TeacherViews;
using DemoCenter.Web.Services.Foundations.Teachers;

namespace DemoCenter.Web.Services.Views.TeacherViews
{
    public class TeacherViewService :ITeacherViewService
    {
        private readonly ITeacherService teacherService;
        private readonly IDateTimeBroker dateTimeBroker;
        private readonly ILoggingBroker loggingBroker;

        public TeacherViewService(
            ITeacherService teacherService,
            IDateTimeBroker dateTimeBroker,
            ILoggingBroker loggingBroker)
        {
            this.teacherService = teacherService;
            this.dateTimeBroker = dateTimeBroker;
            this.loggingBroker = loggingBroker;
        }

        public async ValueTask<List<TeacherView>> RetrieveAllTeacherViewsAsync()
        {
            List<Teacher> teachers = await this.teacherService.RetrieveAllTeachersAsync();

            return teachers.Select(AsTeacherView).ToList();
        }

        private static Func<Teacher, TeacherView> AsTeacherView =>
            teacher => new TeacherView
            {
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                Phone = teacher.Phone,

            };
    }
}
