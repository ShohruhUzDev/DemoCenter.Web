using DemoCenter.Web.Brokers.ApiBrokers;
using DemoCenter.Web.Brokers.DateTimes;
using DemoCenter.Web.Brokers.Loggings;
using DemoCenter.Web.Services.Foundations.Teachers;
using DemoCenter.Web.Services.Foundations.Users;
using DemoCenter.Web.Services.Views.TeacherViews;
using DemoCenter.Web.Services.Views.UserViews;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Syncfusion.Blazor;

namespace DemoCenter
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages(options =>
                options.RootDirectory = "/Views/Pages");


            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddHttpClient();
            builder.Services.AddServerSideBlazor();
            AddBrokers(builder);
            AddServices(builder);
            AddViewServices(builder);

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");
            app.Run();

        }
        private static void AddServices(WebApplicationBuilder builder)
        {

            builder.Services.AddTransient<IUserService, UserService>();
            builder.Services.AddTransient<ITeacherService, TeacherService>();
        }

        private static void AddViewServices(WebApplicationBuilder builder)
        {

            builder.Services.AddTransient<IUserViewService, UserViewService>();
            builder.Services.AddTransient<ITeacherViewService, TeacherViewService>();
        }

        private static void AddBrokers(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IApiBroker, ApiBroker>();
            builder.Services.AddTransient<ILoggingBroker, LoggingBroker>();
            builder.Services.AddTransient<IDateTimeBroker, DateTimeBroker>();
        }
    }
}
