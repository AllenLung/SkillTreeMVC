using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SkillTreeMVC.DataAccess.Data;
using SkillTreeMVC.DataAccess.Interface;
using SkillTreeMVC.DataAccess.Repo;

namespace SkillTreeMVC.DataAccess
{
    public static class AppReposServiceCollection
    {
        public static void AddReposServiceCollection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BlogDbContext>(opt => opt.UseSqlServer(
                (configuration.GetConnectionString("DefaultConnection"))));
            services.AddScoped<IBlogRepo, BlogRepo>();
        }
    }
}
