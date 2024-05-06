using AutoMapper;
using PersonalProjectManagementTool.API.DTOs;
using PersonalProjectManagementTool.API.DTOs.Add;
using PersonalProjectManagementTool.BLL.Models;
using PersonalProjectManagementTool.BLL.Models.AddModels;

namespace PersonalProjectManagementTool.API.WebMapping
{
    public class CardActivityDTOMapperProfile : Profile
    {
        public CardActivityDTOMapperProfile()
        {
            CreateMap<AddCardActivityDTO, AddCardActivityModel>()
                .ForMember(dest => dest.CardId, opt => opt.MapFrom(src => Guid.Parse(src.CardId)))
                .ForMember(dest=>dest.Description,opt=>opt.MapFrom(src=>src.Description));

            CreateMap<CardActivityModel, CardActivityDTO>();
        }
    }
}
