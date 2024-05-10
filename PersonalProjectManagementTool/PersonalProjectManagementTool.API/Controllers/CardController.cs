using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonalProjectManagementTool.API.DTOs;
using PersonalProjectManagementTool.API.DTOs.Add;
using PersonalProjectManagementTool.API.DTOs.Update;
using PersonalProjectManagementTool.BLL.Models.AddModels;
using PersonalProjectManagementTool.BLL.Models.UpdateModels;
using PersonalProjectManagementTool.BLL.Services.Interfaces;

namespace PersonalProjectManagementTool.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICardService _cardService;

        public CardController(ICardService cardService, IMapper mapper)
        {
            _cardService = cardService;
            _mapper = mapper;
        }

        [HttpPost("cards")]
        public async Task<IActionResult> AddCard([FromBody] AddCardDTO addCardDTO)
        {
            var mappedCard = _mapper.Map<AddCardModel>(addCardDTO);
            await _cardService.AddCardAsync(mappedCard);
            return Ok();
        }

        [HttpDelete("cards/{id:guid}")]
        public async Task<IActionResult> RemoveCard(Guid id)
        {
            await _cardService.DeleteCardAsync(id);
            return Ok();
        }

        [HttpPatch("cards/{id:guid}")]
        public async Task<IActionResult> UpdateCard([FromBody] UpdateCardDTO updateCardDTO)
        {
            var mappedCard = _mapper.Map<UpdateCardModel>(updateCardDTO);
            await _cardService.UpdateCardAsync(mappedCard);
            return Ok();
        }

        [HttpGet("cards/{id:guid}")]
        public async Task<IActionResult> FetchCard(Guid id)
        {
            var card = await _cardService.GetCardByIdAsync(id);
            var mappedCard = _mapper.Map<CardDTO>(card);
            return Ok(mappedCard);
        }

        [HttpGet("cards")]
        public async Task<IActionResult> FetchAllCardsAsync()
        {
            var allCard = await _cardService.GetAllCardsAsync();
            var allMappedCard = _mapper.Map<IList<CardDTO>?>(allCard);
            return Ok(allMappedCard);
        }
    }
}