using PersonalProjectManagementTool.BLL.Models;
using PersonalProjectManagementTool.BLL.Models.AddModels;
using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.BLL.Services.Interfaces
{
    public interface ICardActivityService
    {
        public Task AddCardActivityAsync(AddCardActivityModel model);
        public Task<IList<CardActivityModel>?> GetAllCardsActivitiesAsync();
        public Task<IList<CardActivityModel>?> GetAllCardActivitiesByCardIdAsync(Guid id);
    }
}
