using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebStore.Infrastructure.Models;

namespace WebStore.Data
{
    public class WebStoreDbContext : IdentityDbContext
    {
        public WebStoreDbContext(DbContextOptions<WebStoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBook> AuthorsBooks { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<GenreBook> GenresBooks { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<PublisherBook> PublishersBooks { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreBook> StoresBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
