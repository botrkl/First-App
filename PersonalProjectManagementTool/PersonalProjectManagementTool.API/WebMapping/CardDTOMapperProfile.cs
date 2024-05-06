using AutoMapper;
using PersonalProjectManagementTool.API.DTOs;
using PersonalProjectManagementTool.API.DTOs.Add;
using PersonalProjectManagementTool.API.DTOs.Update;
using PersonalProjectManagementTool.BLL.Models;
using PersonalProjectManagementTool.BLL.Models.AddModels;
using PersonalProjectManagementTool.BLL.Models.UpdateModels;

namespace PersonalProjectManagementTool.API.WebMapping
{
    public class CardDTOMapperProfile : Profile
    {
        public CardDTOMapperProfile()
        {
            CreateMap<AddCardDTO, AddCardModel>()
                .ForMember(dest => dest.DueDate, opt => opt.MapFrom(src => DateTime.Parse(src.DueDate)))
                .ForMember(dest => dest.ListId, opt => opt.MapFrom(src => Guid.Parse(src.ListId)))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Priority, opt => opt.MapFrom(src => src.Priority))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

            CreateMap<UpdateCardDTO, UpdateCardModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.Parse(src.Id)))
                .ForMember(dest => dest.DueDate, opt => opt.MapFrom(src => DateTime.Parse(src.DueDate)))
                .ForMember(dest => dest.ListId, opt => opt.MapFrom(src => Guid.Parse(src.ListId)))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Priority, opt => opt.MapFrom(src => src.Priority))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

            CreateMap<CardModel, CardDTO>();
        }
    }
}
