using CoCApp.Api.Services;
using CoCApp.Api.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CoCApp.Api.Extensions
{
    public static class ApiServiceExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<ILogService, LogService>();
        }
    }
}
