using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBooks.Models;

namespace WebApiBooks.Repositories
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = Guid.NewGuid(),
                NameBook = "C# 7 .Net Core",
                Author = "Andrew Troelsen",
                Page = 1328
            }, new Book
            {
                Id = Guid.NewGuid(),
                NameBook = "SQL",
                Author = "Allen G.Taylor",
                Page = 402
            }) ;          
                        
        }
    }
}
