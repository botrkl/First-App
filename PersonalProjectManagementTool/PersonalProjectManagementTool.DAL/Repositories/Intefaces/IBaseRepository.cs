using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.DAL.Repositories.Intefaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity?> GetByIdAsync(Guid id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(Guid id);
        Task<IList<TEntity>?> GetAllAsync();
    }
}