using Microsoft.EntityFrameworkCore;
using Cid.Domain.Models;
using Cid.Domain.Enums;
using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cid.Infra.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Item> Itens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=cid;User Id=SA;Password=Cid12345");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Item>()
                .Property(e => e.Type)
                .HasConversion<string>();
        }
    }
}