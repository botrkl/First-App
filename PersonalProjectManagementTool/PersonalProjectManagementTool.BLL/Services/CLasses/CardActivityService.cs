using AutoMapper;
using PersonalProjectManagementTool.BLL.Models;
using PersonalProjectManagementTool.BLL.Models.AddModels;
using PersonalProjectManagementTool.BLL.Services.Interfaces;
using PersonalProjectManagementTool.DAL.Entities;
using PersonalProjectManagementTool.DAL.Repositories.Intefaces;

namespace PersonalProjectManagementTool.BLL.Services.CLasses
{
    public class CardActivityService : ICardActivityService
    {
        private readonly IMapper _mapper;
        private readonly ICardActivityRepository _cardActivityRepository;
        public CardActivityService(IMapper mapper, ICardActivityRepository cardActivityRepository)
        {
            _mapper = mapper;
            _cardActivityRepository = cardActivityRepository;
        }
        public async Task AddCardActivityAsync(AddCardActivityModel model)
        {
            var addCardActivity = _mapper.Map<CardActivity>(model);
            await _cardActivityRepository.AddAsync(addCardActivity);
        }

        public async Task<IList<CardActivityModel>?> GetAllCardActivitiesByCardIdAsync(Guid id)
        {
            var allCardsActivities = await _cardActivityRepository.GetAllCardActivitiesByCardIdAsync(id);
            return _mapper.Map<IList<CardActivityModel>?>(allCardsActivities);
        }

        public async Task<IList<CardActivityModel>?> GetAllCardsActivitiesAsync()
        {
            var allCardsActivities = await _cardActivityRepository.GetAllAsync();
            return _mapper.Map<IList<CardActivityModel>?>(allCardsActivities);
        }
    }
}
