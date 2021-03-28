using CoCApp.DataAccess.Sql.Contexts;
using CoCApp.DataAccess.Sql.Entities;
using CoCApp.DataAccess.Sql.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoCApp.DataAccess.Sql.Extensions
{
    public static class DataAccessExtensions
    {
        public static void AddSqlServerConnection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("CoCApp.DataAccess.Sql"))
            );
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<ILogRepository, LogRepository>();
            services.AddTransient<IInspectorRepository, InspectorRepository>();
            services.AddTransient<IRepository<SkillDefinition>, SkillDefinitionRepository>();
        }
    }
}
