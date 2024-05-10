using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonalProjectManagementTool.API.DTOs.Add;
using PersonalProjectManagementTool.API.DTOs.Update;
using PersonalProjectManagementTool.BLL.Models.AddModels;
using PersonalProjectManagementTool.BLL.Models.UpdateModels;
using PersonalProjectManagementTool.BLL.Services.Interfaces;

namespace PersonalProjectManagementTool.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class ListOfCardsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IListOfCardsService _listOfCardsService;
        public ListOfCardsController(IMapper mapper, IListOfCardsService listOfCardsService)
        {
            _mapper = mapper;
            _listOfCardsService = listOfCardsService;
        }

        [HttpPost("lists")]
        public async Task<IActionResult> AddList([FromBody] AddListOfCardsDTO addListDTO)
        {
            var mappedList = _mapper.Map<AddListOfCardsModel>(addListDTO);
            await _listOfCardsService.AddListOfCardsAsync(mappedList);
            return Ok();
        }

        [HttpDelete("list/{id:guid}")]
        public async Task<IActionResult> RemoveList(Guid id)
        {
            await _listOfCardsService.DeleteListOfCardsAsync(id);
            return Ok();
        }

        [HttpPatch("list/{id:guid}")]
        public async Task<IActionResult> UpdateList([FromBody] UpdateListOfCardsDTO updateListDTO)
        {
            var mappedList = _mapper.Map<UpdateListOfCardsModel>(updateListDTO);
            await _listOfCardsService.UpdateListOfCardsAsync(mappedList);
            return Ok();
        }
    }
}
