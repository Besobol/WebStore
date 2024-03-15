using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Models;

namespace WebStore.Infrastructure.Data.SeedDb
{
    internal class AuthorBookConfiguration : IEntityTypeConfiguration<AuthorBook>
    {
        public void Configure(EntityTypeBuilder<AuthorBook> builder)
        {
            builder.HasData(DataSeed);
        }

        private static AuthorBook[] DataSeed 
            => [
                new AuthorBook(){
                    BookId = 1,
                    AuthorId = 1,
                },
                new AuthorBook(){
                    BookId = 2,
                    AuthorId = 2,
                },
                new AuthorBook(){
                    BookId = 3,
                    AuthorId = 3,
                },
                new AuthorBook(){
                    BookId = 4,
                    AuthorId = 4,
                },
                new AuthorBook(){
                    BookId = 5,
                    AuthorId = 5,
                },
                new AuthorBook(){
                    BookId = 6,
                    AuthorId = 6,
                },
                new AuthorBook(){
                    BookId = 7,
                    AuthorId = 5,
                }
            ];
    }
}
