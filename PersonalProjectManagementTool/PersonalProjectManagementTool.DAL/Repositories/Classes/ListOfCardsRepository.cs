using Microsoft.EntityFrameworkCore;
using PersonalProjectManagementTool.DAL.Context;
using PersonalProjectManagementTool.DAL.Entities;
using PersonalProjectManagementTool.DAL.Repositories.Intefaces;

namespace PersonalProjectManagementTool.DAL.Repositories.Classes
{
    public class ListOfCardsRepository : BaseRepository<ListOfCards>, IListOfCardsRepository
    {
        private BoardDbContext _dbContext;
        public ListOfCardsRepository(BoardDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IList<ListOfCards>?> GetAllListOfCardsWithCardsAsync() 
        {
            return await _dbContext.Set<ListOfCards>()
                .Include(x => x.Cards).ToListAsync();
        }
    }
}