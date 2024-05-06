using AutoMapper;
using PersonalProjectManagementTool.BLL.Models.AddModels;
using PersonalProjectManagementTool.BLL.Models.UpdateModels;
using PersonalProjectManagementTool.BLL.Models;
using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.BLL.Mapping
{
    public class ListOfCardsModelMapperProfile : Profile
    {
        public ListOfCardsModelMapperProfile()
        {
            CreateMap<AddListOfCardsModel, ListOfCards>();
            CreateMap<UpdateListOfCardsModel, ListOfCards>();
            CreateMap<ListOfCards, ListOfCardsModel>();
        }
    }
}
