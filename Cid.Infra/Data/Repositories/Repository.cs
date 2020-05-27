using Cid.Infra.Data.Contracts;

namespace Cid.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        private readonly DatabaseContext _dbcontext;

        public Repository(DatabaseContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public void Add(T entity)
        {
            _dbcontext.Add(entity);
        }
    }
}