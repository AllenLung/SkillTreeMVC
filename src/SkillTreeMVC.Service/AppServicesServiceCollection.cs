using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SkillTreeMVC.DataAccess;
using SkillTreeMVC.Service.Interface;

namespace SkillTreeMVC.Service
{
    public static class AppServicesServiceCollection
    {
        public static void AddServicesServiceCollection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddReposServiceCollection(configuration);
            services.AddScoped<IBlogService, BlogService>();
        }
    }
}
