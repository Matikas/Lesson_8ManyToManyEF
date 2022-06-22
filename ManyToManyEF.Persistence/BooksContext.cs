using ManyToManyEF.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyEF.Persistence
{
    public class BooksContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BooksDbManyToMany;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().Property(p => p.Id).HasDefaultValueSql("newid()");
            modelBuilder.Entity<Category>().Property(p => p.Id).HasDefaultValueSql("newid()");
        }
    }
}
