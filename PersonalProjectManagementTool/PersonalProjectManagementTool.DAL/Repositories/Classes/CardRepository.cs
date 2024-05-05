using PersonalProjectManagementTool.DAL.Context;
using PersonalProjectManagementTool.DAL.Entities;
using PersonalProjectManagementTool.DAL.Repositories.Intefaces;

namespace PersonalProjectManagementTool.DAL.Repositories.Classes
{
    public class CardRepository : BaseRepository<Card>, ICardRepository
    {
        private BoardDbContext _dbContext;
        public CardRepository(BoardDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}