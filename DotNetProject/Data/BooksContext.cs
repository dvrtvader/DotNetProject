using DotNetProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetProject.Data
{
    public class BooksContext:IdentityDbContext
    {
        public BooksContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Poster> Poster { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ReadingCard> ReadingCard { get; set; }
        public DbSet<BookGenreR> BookGenreR { get; set; }
        public DbSet<BookReadingCardR> BookReadingCard { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasOne(a => a.readingCard)
                .WithOne(a => a.user)
                .HasForeignKey<ReadingCard>(c => c.userId);

            modelBuilder.Entity<BookGenreR>()
                .HasKey(a => new { a.bookId, a.genreId });
            modelBuilder.Entity<BookReadingCardR>()
                .HasKey(a => new { a.bookId, a.readingCardId });

            modelBuilder.Entity<Book>()
                .HasOne<Author>(s => s.author)
                .WithMany(b => b.books)
                .HasForeignKey(s => s.authorId);
            modelBuilder.Entity<Book>()
                .HasOne<Poster>(s => s.poster)
                .WithMany(b => b.books)
                .HasForeignKey(s => s.posterId);
            }
    }
}
