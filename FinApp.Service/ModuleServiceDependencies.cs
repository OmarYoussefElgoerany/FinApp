using FinApp.Service.Abstracts;
using FinApp.Service.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace SchoolProject.Service
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IAccountService,AccountService>();
            services.AddTransient<IUserService, UserService>();


            return services;
        }
    }
}