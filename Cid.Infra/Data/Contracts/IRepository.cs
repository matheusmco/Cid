using System.Collections.Generic;

namespace Cid.Infra.Data.Contracts
{
    public interface IRepository<TEntity>
    {
         TEntity GetById(int id);
         IEnumerable<TEntity> GetAll();
         void Save(TEntity entity);
         void Update(TEntity entity);
         void Delete(TEntity entity);
    }
}