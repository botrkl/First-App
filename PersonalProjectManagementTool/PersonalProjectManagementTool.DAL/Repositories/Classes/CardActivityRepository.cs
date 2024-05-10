using Microsoft.EntityFrameworkCore;
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

        public async Task<IList<CardActivity>?> GetAllCardActivitiesByCardIdAsync(Guid id)
        {
            return await _dbContext.Set<CardActivity>()
                .Where(x => x.CardId == id)
                .ToListAsync();
        }
    }
}