using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Cid.Domain.Entities;

namespace Cid.Infra.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Comic> Comics { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}