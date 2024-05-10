using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonalProjectManagementTool.API.DTOs;
using PersonalProjectManagementTool.BLL.Services.CLasses;
using PersonalProjectManagementTool.BLL.Services.Interfaces;

namespace PersonalProjectManagementTool.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class CardActivityController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICardActivityService _cardActivityService;
        public CardActivityController(ICardActivityService cardActivityService, IMapper mapper)
        {
            _cardActivityService = cardActivityService;
            _mapper = mapper;
        }
        [HttpGet("history")]
        public async Task<IActionResult> FetchAllHistoryAsync()
        {
            var allHistory = await _cardActivityService.GetAllCardsActivitiesAsync();
            var allMappedHistory = _mapper.Map<IList<CardActivityDTO>?>(allHistory);
            return View(allMappedHistory);
        }
        [HttpGet("history/{id:guid}")]
        public async Task<IActionResult> CategoryHistoryAsync(Guid id)
        {
            var allHistory = await _cardActivityService.GetAllCardsActivitiesAsync();
            var allMappedHistory = _mapper.Map<IList<CardActivityDTO>?>(allHistory);
            return View(allMappedHistory);
        }
    }
}
