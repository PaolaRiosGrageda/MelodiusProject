using MelodiusModels.Base;

namespace MelodiusDataAccess.Repository.Base
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task <List<TEntity>> GetAllAsync();
       Task <TEntity> GetOneAsync(int id);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> Delete(int id);
        Task<TEntity> Update(TEntity entity);

    }
}
