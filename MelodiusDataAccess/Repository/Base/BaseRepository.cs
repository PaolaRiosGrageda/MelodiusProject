using MelodiusDataAccess.Persistence;
using MelodiusModels.Base;
using Microsoft.EntityFrameworkCore;

namespace MelodiusDataAccess.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly MelodiusContext _melodiusContext;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(MelodiusContext melodiusContext)
        {
            _melodiusContext = melodiusContext;
            _dbSet = _melodiusContext.Set<TEntity>();
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            var createdEntity = (await _dbSet.AddAsync(entity)).Entity;
            await _melodiusContext.SaveChangesAsync();
            return createdEntity;
        }

        public  TEntity Delete(int id)
        {
            var entityToDelete =  _dbSet.Find(id);
              _dbSet.Remove(entityToDelete);
            return entityToDelete;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetOneAsync(int id)
        {
            var test =  _dbSet.Where(x => x.Id == id);
            var findObject =  _dbSet.Where(x => x.Id == id).First();
            return findObject;
        }

        public TEntity Update(TEntity entity)
        {
            _dbSet.Update(entity);
            _melodiusContext.SaveChanges();
            return entity;
        }
    }
}
