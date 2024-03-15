using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Models;

namespace WebStore.Infrastructure.Data.SeedDb
{
    internal class GenreBookConfiguration : IEntityTypeConfiguration<GenreBook>
    {
        public void Configure(EntityTypeBuilder<GenreBook> builder)
        {
            builder.HasData(DataSeed);
        }

        private static GenreBook[] DataSeed 
            => [
                new GenreBook(){
                    BookId = 1,
                    GenreId = 1
                },
                new GenreBook(){
                    BookId = 2,
                    GenreId = 6
                },
                new GenreBook(){
                    BookId = 3,
                    GenreId = 17
                },
                new GenreBook(){
                    BookId = 4,
                    GenreId = 4
                },
                new GenreBook(){
                    BookId = 5,
                    GenreId = 11
                },
                new GenreBook(){
                    BookId = 6,
                    GenreId = 10
                },
                new GenreBook(){
                    BookId = 7,
                    GenreId = 11
                }
            ];
    }
}
