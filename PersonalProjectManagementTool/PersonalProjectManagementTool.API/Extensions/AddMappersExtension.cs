using PersonalProjectManagementTool.API.WebMapping;
using PersonalProjectManagementTool.BLL.Mapping;

namespace PersonalProjectManagementTool.API.Extensions
{
    public static class AddMappersExtension
    {
        public static void AddMappers(this IServiceCollection service)
        {
            service.AddAutoMapper(typeof(CardActivityDTOMapperProfile));
            service.AddAutoMapper(typeof(CardMapperProfile));
            service.AddAutoMapper(typeof(ListOfCardsModelMapperProfile));
        }
    }
}
