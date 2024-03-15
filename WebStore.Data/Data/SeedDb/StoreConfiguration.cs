using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Models;

namespace WebStore.Infrastructure.Data.SeedDb
{
    internal class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasData(DataSeed);
        }

        private static Store[] DataSeed
            => [
                new Store()
                {
                    Id = 1,
                    Name = "Orange",
                    Website = "https://www.orangecenter.bg/"
                },
                new Store()
                {
                    Id = 2,
                    Name = "Bookpoint",
                    Website = "https://www.bookpoint.bg/"
                },
                new Store()
                {
                    Id = 3,
                    Name = "Ciela",
                    Website = "https://www.ciela.com/"
                }
            ];
    }
}
