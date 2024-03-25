using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebStore.Infrastructure.Data.Models;
using WebStore.Infrastructure.Data.SeedDb;

namespace WebStore.Infrastructure.Data
{
    public class WebStoreDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
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
            // Add base data seed
            builder.ApplyConfiguration(new AuthorConfiguration());
            builder.ApplyConfiguration(new BookConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());
            builder.ApplyConfiguration(new PublisherConfiguration());
            builder.ApplyConfiguration(new StoreConfiguration());
            //builder.ApplyConfiguration(new UserConfiguration());
            //builder.ApplyConfiguration(new RoleConfiguration());

            // Add mapping table data seed
            builder.ApplyConfiguration(new AuthorBookConfiguration());
            builder.ApplyConfiguration(new GenreBookConfiguration());
            builder.ApplyConfiguration(new PublisherBookConfiguration());
            builder.ApplyConfiguration(new StoreBookConfiguration());
            //builder.ApplyConfiguration(new UserRoleConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
