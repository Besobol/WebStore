using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Models;

namespace WebStore.Infrastructure.Data.SeedDb
{
    internal class PublisherBookConfiguration : IEntityTypeConfiguration<PublisherBook>
    {
        public void Configure(EntityTypeBuilder<PublisherBook> builder)
        {
            builder.HasData(DataSeed);
        }

        private static PublisherBook[] DataSeed
            => [
                new PublisherBook(){
                    PublisherId = 1,
                    BookId = 1,
                },
                new PublisherBook(){
                    PublisherId = 1,
                    BookId = 2
                },
                new PublisherBook(){
                    PublisherId = 2,
                    BookId = 3
                },
                new PublisherBook(){
                    PublisherId = 2,
                    BookId = 4
                },
                new PublisherBook(){
                    PublisherId = 3,
                    BookId = 5
                },
                new PublisherBook(){
                    PublisherId = 3,
                    BookId = 6
                },
                new PublisherBook(){
                    PublisherId = 3,
                    BookId = 7
                },
            ];
    }
}
