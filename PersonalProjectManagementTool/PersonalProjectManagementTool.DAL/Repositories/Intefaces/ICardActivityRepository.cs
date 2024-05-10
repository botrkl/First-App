using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.DAL.Repositories.Intefaces
{
    public interface ICardActivityRepository : IBaseRepository<CardActivity>
    {
        public Task<IList<CardActivity>?> GetAllCardActivitiesByCardIdAsync(Guid id);
    }
}