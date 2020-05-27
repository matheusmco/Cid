namespace Cid.Infra.Data.Contracts
{
    public interface IRepository<TEntity>
    {
         void Add(TEntity entity);
    }
}