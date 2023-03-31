using MelodiusModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataAccess.Repository.Base
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task <List<TEntity>> GetAllAsync();
        TEntity GetOne(int id);
        Task<TEntity> CreateAsync(TEntity entity);
        TEntity Update(TEntity entity);
        Task<TEntity> Delete(int id);
    }
}
