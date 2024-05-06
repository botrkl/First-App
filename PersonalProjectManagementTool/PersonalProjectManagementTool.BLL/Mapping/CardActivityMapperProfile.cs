using AutoMapper;
using PersonalProjectManagementTool.BLL.Models.AddModels;
using PersonalProjectManagementTool.BLL.Models;
using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.BLL.Mapping
{
    public class CardActivityMapperProfile : Profile
    {
        public CardActivityMapperProfile()
        {
            CreateMap<AddCardActivityModel, CardActivity>();
            CreateMap<CardActivity, CardActivityModel>();
        }
    }
}
