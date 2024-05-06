using PersonalProjectManagementTool.BLL.Models;
using PersonalProjectManagementTool.BLL.Models.AddModels;
using PersonalProjectManagementTool.BLL.Models.UpdateModels;

namespace PersonalProjectManagementTool.BLL.Services.Interfaces
{
    public interface ICardService
    {
        public Task<CardModel> GetCardByIdAsync(Guid id);
        public Task DeleteCardAsync(Guid id);
        public Task AddCardAsync(AddCardModel model);
        public Task UpdateCardAsync(UpdateCardModel model);
        public Task<IList<CardModel>?> GetAllCardsAsync();
    }
}
