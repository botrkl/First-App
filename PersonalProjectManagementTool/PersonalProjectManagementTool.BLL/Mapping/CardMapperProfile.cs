using AutoMapper;
using PersonalProjectManagementTool.BLL.Models.AddModels;
using PersonalProjectManagementTool.BLL.Models.UpdateModels;
using PersonalProjectManagementTool.BLL.Models;
using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.BLL.Mapping
{
    public class CardMapperProfile : Profile
    {
        public CardMapperProfile()
        {
            CreateMap<AddCardModel, Card>();
            CreateMap<UpdateCardModel, Card>();
            CreateMap<Card, CardModel>();
        }
    }
}
