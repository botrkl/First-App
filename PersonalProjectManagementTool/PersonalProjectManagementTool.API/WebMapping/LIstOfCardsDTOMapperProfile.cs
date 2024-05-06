using AutoMapper;
using PersonalProjectManagementTool.API.DTOs;
using PersonalProjectManagementTool.API.DTOs.Add;
using PersonalProjectManagementTool.API.DTOs.Update;
using PersonalProjectManagementTool.BLL.Models;
using PersonalProjectManagementTool.BLL.Models.AddModels;
using PersonalProjectManagementTool.BLL.Models.UpdateModels;

namespace PersonalProjectManagementTool.API.WebMapping
{
    public class LIstOfCardsDTOMapperProfile : Profile
    {
        public LIstOfCardsDTOMapperProfile()
        {
            CreateMap<AddListOfCardsDTO, AddListOfCardsModel>();
            CreateMap<UpdateListOfCardsDTO, UpdateListOfCardsModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => new Guid(src.Id)))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));
            
            CreateMap<ListOfCardsModel, ListOfCardsDTO>();
        }
    }
}
