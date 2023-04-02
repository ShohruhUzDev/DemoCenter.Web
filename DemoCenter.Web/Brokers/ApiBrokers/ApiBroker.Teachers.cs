using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoCenter.Web.Models.Teachers;

namespace DemoCenter.Web.Brokers.ApiBrokers
{
    public partial class ApiBroker
    {
        private const string TeachersRelativeUrl = "api/teachers";

        public async ValueTask<Teacher> PostTeacherAsync(Teacher teacher) =>
            await this.PostAsync(TeachersRelativeUrl, teacher);

        public async ValueTask<List<Teacher>> GetAllTeachersAsync() =>
            await this.GetAsync<List<Teacher>>(TeachersRelativeUrl);

        public async ValueTask<Teacher> GetTeacherByIdAsync(Guid teacherId) =>
            await this.GetAsync<Teacher>($"{TeachersRelativeUrl}/{teacherId}");

        public async ValueTask<Teacher> PutTeacherAsync(Teacher teacher) =>
            await this.PutAsync<Teacher>(UsersRelativeUrl, teacher);

        public async ValueTask<Teacher> DeleteTeacherAsync(Guid teacherId) =>
            await this.DeleteAsync<Teacher>($"{TeachersRelativeUrl}/{teacherId}");

    }
}
