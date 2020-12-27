using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SkillTreeMVC.DataAccess;

namespace SkillTreeMVC.Service
{
    public static class AppServicesServiceCollection
    {
        public static void AddServicesServiceCollection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddReposServiceCollection(configuration);
        }
    }
}
