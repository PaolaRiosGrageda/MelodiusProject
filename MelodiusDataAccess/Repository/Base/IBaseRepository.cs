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
       Task <TEntity> GetOneAsync(int id);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        TEntity Delete(int id);
    }
}
