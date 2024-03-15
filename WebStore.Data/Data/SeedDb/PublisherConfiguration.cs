using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Models;

namespace WebStore.Infrastructure.Data.SeedDb
{
    internal class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasData(DataSeed);
        }

        private static Publisher[] DataSeed 
            => [
                new Publisher()
                {
                    Id = 1,
                    Name = "Tor",
                    Description = "Tor Books, the flagship imprint of the Tor Publishing Group, is renowned for publishing an extensive and diverse array of science fiction and fantasy titles. As one of the leading publishers in this genre, Tor’s mission is to bring readers out-of-this-world genre fiction that fuels the imagination. Whether you’re exploring distant galaxies, magical realms, or thrilling adventures, Tor Books has something for every speculative fiction enthusiast."
                },
                new Publisher()
                {
                    Id= 2,
                    Name = "TCK",
                    Description = "TCK Publishing is an independent book publisher that specializes in both fiction and nonfiction. They publish a wide range of eBooks, print books, and audiobooks across various genres and niches. Their mission is to bring meaningful and inspirational stories to readers around the world."
                },
                new Publisher()
                {
                    Id = 3,
                    Name = "Penguin Random House",
                    Description = "Penguin Random House is the international home to more than 300 editorially and creatively independent publishing imprints. Our mission is to ignite a universal passion for reading by creating books for everyone. We believe that books, and the stories and ideas they hold, have the unique capacity to connect us, change us, and carry us toward a better future for generations to come."
                }
            ];
    }
}
