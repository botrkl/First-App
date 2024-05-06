using Microsoft.Extensions.DependencyInjection;
using PersonalProjectManagementTool.BLL.Mapping;
using PersonalProjectManagementTool.BLL.Services.CLasses;
using PersonalProjectManagementTool.BLL.Services.Interfaces;

namespace PersonalProjectManagementTool.BLL.Extensions
{
    public static class BLLServiceCollectionExtension
    {
        public static void InjectBLL(this IServiceCollection services)
        {
            services.AddScoped<IListOfCardsService, ListOfCardsService>();
            services.AddScoped<ICardService, CardService>();
            services.AddScoped<ICardActivityService, CardActivityService>();

            services.AddAutoMapper(typeof(CardMapperProfile));
            services.AddAutoMapper(typeof(CardActivityMapperProfile));
            services.AddAutoMapper(typeof(ListOfCardsModelMapperProfile));
        }
    }
}
