using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.DAL.Repositories.Intefaces
{
    public interface IListOfCardsRepository : IBaseRepository<ListOfCards>
    {
        public Task<IList<ListOfCards>?> GetAllListOfCardsWithCardsAsync();
    }
}