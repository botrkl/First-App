using PersonalProjectManagementTool.DAL.Context;
using PersonalProjectManagementTool.DAL.Entities;
using PersonalProjectManagementTool.DAL.Repositories.Intefaces;

namespace PersonalProjectManagementTool.DAL.Repositories.Classes
{
    public class CardActivityRepository : BaseRepository<CardActivity>, ICardActivityRepository
    {
        private BoardDbContext _dbContext;
        public CardActivityRepository(BoardDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}