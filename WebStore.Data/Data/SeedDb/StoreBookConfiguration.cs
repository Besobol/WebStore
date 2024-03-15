using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Models;

namespace WebStore.Infrastructure.Data.SeedDb
{
    internal class StoreBookConfiguration : IEntityTypeConfiguration<StoreBook>
    {
        public void Configure(EntityTypeBuilder<StoreBook> builder)
        {
            builder.HasData(DataSeed);
        }

        private static StoreBook[] DataSeed
            => [
                new StoreBook(){
                    BookId = 1,
                    StoreId = 1,
                },
                new StoreBook(){
                    BookId = 1,
                    StoreId = 2,
                },
                new StoreBook(){
                    BookId = 1,
                    StoreId = 3,
                },
                new StoreBook(){
                    BookId = 2,
                    StoreId = 2,
                },
                new StoreBook(){
                    BookId = 2,
                    StoreId = 3,
                },
                new StoreBook(){
                    BookId = 3,
                    StoreId = 1,
                },
                new StoreBook(){
                    BookId = 3,
                    StoreId = 2,
                },
            ];
    }
}
