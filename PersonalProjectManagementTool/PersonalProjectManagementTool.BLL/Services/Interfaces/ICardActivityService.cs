using PersonalProjectManagementTool.BLL.Models;
using PersonalProjectManagementTool.BLL.Models.AddModels;

namespace PersonalProjectManagementTool.BLL.Services.Interfaces
{
    public interface ICardActivityService
    {
        public Task AddCardActivityAsync(AddCardActivityModel model);
        public Task<IList<CardActivityModel>?> GetAllCardsActivitiesAsync();
    }
}
