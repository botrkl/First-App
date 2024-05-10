using AutoMapper;
using PersonalProjectManagementTool.BLL.Models;
using PersonalProjectManagementTool.BLL.Models.AddModels;
using PersonalProjectManagementTool.BLL.Models.UpdateModels;
using PersonalProjectManagementTool.BLL.Services.Interfaces;
using PersonalProjectManagementTool.DAL.Entities;
using PersonalProjectManagementTool.DAL.Repositories.Classes;
using PersonalProjectManagementTool.DAL.Repositories.Intefaces;

namespace PersonalProjectManagementTool.BLL.Services.CLasses
{
    public class CardService : ICardService
    {
        private readonly IMapper _mapper;
        private readonly ICardRepository _cardRepository;
        private readonly ICardActivityRepository _cardActivityRepository;
        public CardService(IMapper mapper, ICardRepository cardRepository, ICardActivityRepository cardActivityRepository)
        {
             _mapper = mapper;
            _cardRepository = cardRepository;
            _cardActivityRepository = cardActivityRepository;
        }
        public async Task AddCardAsync(AddCardModel model)
        {
            var addCard = _mapper.Map<Card>(model);
            await _cardRepository.AddAsync(addCard);

            await _cardActivityRepository.AddAsync(new CardActivity() { CardId= addCard .Id,Description="Was added.",TimeOfAction=DateTime.UtcNow});
        }

        public async Task DeleteCardAsync(Guid id)
        {
            await _cardRepository.DeleteAsync(id);
        }

        public async Task<IList<CardModel>?> GetAllCardsAsync()
        {
            var allCards = await _cardRepository.GetAllAsync();
            return _mapper.Map<IList<CardModel>?>(allCards);
        }

        public async Task<CardModel> GetCardByIdAsync(Guid id)
        {
            var wantedCard = await _cardRepository.GetByIdAsync(id);
            return _mapper.Map<CardModel>(wantedCard);
        }

        public async Task UpdateCardAsync(UpdateCardModel model)
        {
            var tempCard = await _cardRepository.GetByIdAsync(model.Id);
            _mapper.Map(model, tempCard);
            await _cardRepository.UpdateAsync(tempCard);
            await _cardActivityRepository.AddAsync(new CardActivity() { CardId = model.Id, Description = "Was updated.", TimeOfAction = DateTime.UtcNow });
        }
    }
}
