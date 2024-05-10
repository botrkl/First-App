using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonalProjectManagementTool.API.DTOs;
using PersonalProjectManagementTool.BLL.Services.Interfaces;

namespace PersonalProjectManagementTool.API.Controllers
{
    [Route("/api")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IListOfCardsService _listOfCardsService;
        public BoardController(IMapper mapper, IListOfCardsService listOfCardsService)
        {
            _mapper = mapper;
            _listOfCardsService = listOfCardsService;
        }
        [HttpGet("/")]
        [HttpGet("/board")]
        public async Task<IActionResult> FetchAllLists()
        {
            var allList = await _listOfCardsService.GetAllListsOfCardsAsync();
            var allMappedList = _mapper.Map<List<ListOfCardsDTO>?>(allList);
            return Ok(allMappedList);
        }
    }
}
