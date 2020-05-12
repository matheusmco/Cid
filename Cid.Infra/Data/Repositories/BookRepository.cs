using System.Collections.Generic;
using System.Linq;
using Cid.Domain.Entities;
using Cid.Infra.Data.Contracts;

namespace Cid.Infra.Data.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        private readonly DatabaseContext _dbcontext;
        public BookRepository(DatabaseContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public void Delete(Book entity) => _dbcontext.Remove(entity);

        public IEnumerable<Book> GetAll() => _dbcontext.Books.AsQueryable();

        public Book GetById(int id) => _dbcontext.Books.FirstOrDefault(x => x.Id == id);

        public void Save(Book entity) => _dbcontext.Books.AddAsync(entity);

        public void Update(Book entity) => _dbcontext.Books.Update(entity);

        public void Flush() => _dbcontext.SaveChangesAsync();
    }
}