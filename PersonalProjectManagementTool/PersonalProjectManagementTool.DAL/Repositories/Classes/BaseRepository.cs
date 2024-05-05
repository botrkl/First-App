using Microsoft.EntityFrameworkCore;
using PersonalProjectManagementTool.DAL.Context;
using PersonalProjectManagementTool.DAL.Entities;
using PersonalProjectManagementTool.DAL.Repositories.Intefaces;

namespace PersonalProjectManagementTool.DAL.Repositories.Classes
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private BoardDbContext _dbContext;
        public BaseRepository(BoardDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            var removeEntity = await _dbContext.Set<TEntity>().FirstAsync(x => x.Id == id);
            _dbContext.Set<TEntity>().Remove(removeEntity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<IList<TEntity>?> GetAllAsync()
        {
            var result = await _dbContext.Set<TEntity>().ToListAsync();
            return result;
        }
        public async Task<TEntity?> GetByIdAsync(Guid id)
        {
            var searchedEntity = await _dbContext.Set<TEntity>().FirstAsync(x => x.Id == id);
            return searchedEntity;
        }
        public async Task UpdateAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}