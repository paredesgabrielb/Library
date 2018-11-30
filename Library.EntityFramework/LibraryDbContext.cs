using Library.Domain;
using Library.Infraestructure.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.EntityFramework
{
    public class LibraryDbContext : GenericRepositoryContext
    {

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
        }

        public LibraryDbContext()
        {
        }


        public DbSet<Book> Books { get; set; }
        public DbSet<Page> Pages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new Book { Id = 1, Author = "Gabriel Garcia", Title = "Los dias finales en DIGEPRES", isBN = "Test" });


            modelBuilder.Entity<Page>().HasData(new Page { Id = 1, BookId = 1, FileName = "Digepres1", Format = "PDF" });
            modelBuilder.Entity<Page>().HasData(new Page { Id = 2, BookId = 1, FileName = "Digepres2", Format = "PDF" });
            modelBuilder.Entity<Page>().HasData(new Page { Id = 3, BookId = 1, FileName = "Digepres3", Format = "PDF" });


            base.OnModelCreating(modelBuilder);
        }
    }
}
