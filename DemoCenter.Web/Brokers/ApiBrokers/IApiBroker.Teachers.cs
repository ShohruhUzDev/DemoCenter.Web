using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoCenter.Web.Models.Teachers;

namespace DemoCenter.Web.Brokers.ApiBrokers
{
    public partial interface IApiBroker
    {
        ValueTask<Teacher> PostTeacherAsync(Teacher teacher);
        ValueTask<List<Teacher>> GetAllTeachersAsync();
        ValueTask<Teacher> GetTeacherByIdAsync(Guid teacherId);
        ValueTask<Teacher> PutTeacherAsync(Teacher teacher);
        ValueTask<Teacher> DeleteTeacherAsync(Guid teacherId);
    }
}
