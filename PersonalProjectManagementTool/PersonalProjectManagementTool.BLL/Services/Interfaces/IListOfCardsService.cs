using PersonalProjectManagementTool.BLL.Models.AddModels;
using PersonalProjectManagementTool.BLL.Models.UpdateModels;
using PersonalProjectManagementTool.BLL.Models;
using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.BLL.Services.Interfaces
{
    public interface IListOfCardsService
    {
        public Task<ListOfCardsModel> GetListOfCardsByIdAsync(Guid id);
        public Task DeleteListOfCardsAsync(Guid id);
        public Task AddListOfCardsAsync(AddListOfCardsModel model);
        public Task UpdateListOfCardsAsync(UpdateListOfCardsModel model);
        public Task<IList<ListOfCardsModel>?> GetAllListsOfCardsAsync();
        public Task<IList<ListOfCardsModel>?> GetAllListOfCardsWithCardsAsync();
    }
}
