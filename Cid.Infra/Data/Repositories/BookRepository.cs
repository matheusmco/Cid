using Cid.Domain.Entities;
using Cid.Domain.RepositoryContracts;
using Cid.Infra.Data.Contracts;

namespace Cid.Infra.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DatabaseContext _dbcontext;
        private readonly IRepository<Book> _repository;
        public BookRepository(DatabaseContext dbContext, IRepository<Book> repository)
        {
            _dbcontext = dbContext;
            _repository = repository;
        }

        public void Add(Book book) => _repository.Add(book);
    }
}