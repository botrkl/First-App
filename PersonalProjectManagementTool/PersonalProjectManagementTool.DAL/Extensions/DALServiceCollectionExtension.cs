using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersonalProjectManagementTool.DAL.Context;
using PersonalProjectManagementTool.DAL.Repositories.Classes;
using PersonalProjectManagementTool.DAL.Repositories.Intefaces;

namespace PersonalProjectManagementTool.DAL.Extensions
{
    public static class DALServiceCollectionExtension
    {
        public static void InjectDAL(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<BoardDbContext>(options =>
            {
                options.UseNpgsql(configuration["ConnectionString"]);
            });
            services.AddScoped<ICardActivityRepository, CardActivityRepository>();
            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<IListOfCardsRepository, ListOfCardsRepository>();
        }
    }
}
