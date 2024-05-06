using AutoMapper;
using PersonalProjectManagementTool.BLL.Models;
using PersonalProjectManagementTool.BLL.Models.AddModels;
using PersonalProjectManagementTool.BLL.Models.UpdateModels;
using PersonalProjectManagementTool.BLL.Services.Interfaces;
using PersonalProjectManagementTool.DAL.Entities;
using PersonalProjectManagementTool.DAL.Repositories.Intefaces;

namespace PersonalProjectManagementTool.BLL.Services.CLasses
{
    public class ListOfCardsService : IListOfCardsService
    {
        private readonly IMapper _mapper;
        private readonly IListOfCardsRepository _listOfCardsRepository;
        public ListOfCardsService(IMapper mapper, IListOfCardsRepository listOfCardsRepository)
        {
            _mapper = mapper;
            _listOfCardsRepository = listOfCardsRepository;
        }
        public async Task AddListOfCardsAsync(AddListOfCardsModel model)
        {
            var listOfCards = _mapper.Map<ListOfCards>(model);
            await _listOfCardsRepository.AddAsync(listOfCards);
        }

        public async Task DeleteListOfCardsAsync(Guid id)
        {
            await _listOfCardsRepository.DeleteAsync(id);
        }

        public async Task<IList<ListOfCardsModel>?> GetAllListsOfCardsAsync()
        {
            var allListOfCards = await _listOfCardsRepository.GetAllAsync();
            return _mapper.Map<IList<ListOfCardsModel>?>(allListOfCards);
        }

        public async Task<ListOfCardsModel> GetListOfCardsByIdAsync(Guid id)
        {
            var wantedListOfCards = await _listOfCardsRepository.GetByIdAsync(id);
            return _mapper.Map<ListOfCardsModel>(wantedListOfCards);
        }

        public async Task UpdateListOfCardsAsync(UpdateListOfCardsModel model)
        {
            var tempListOfCards = await _listOfCardsRepository.GetByIdAsync(model.Id);
            _mapper.Map(model, tempListOfCards);
            await _listOfCardsRepository.UpdateAsync(tempListOfCards);
        }
    }
}
