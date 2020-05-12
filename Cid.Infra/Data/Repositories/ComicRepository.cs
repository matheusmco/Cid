using System.Collections.Generic;
using Cid.Domain.Entities;
using Cid.Infra.Data.Contracts;

namespace Cid.Infra.Data.Repositories
{
    public class ComicRepository : IRepository<Comic>
    {
        private readonly DatabaseContext _dbcontext;
        public ComicRepository(DatabaseContext databaseContext)
        {
            _dbcontext = databaseContext;
        }

        public void Delete(Comic entity) => _dbcontext.Comics.Remove(entity);

        public IEnumerable<Comic> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Comic GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Comic entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Comic entity)
        {
            throw new System.NotImplementedException();
        }
    }
}