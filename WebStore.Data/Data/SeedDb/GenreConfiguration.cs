using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Models;

namespace WebStore.Infrastructure.Data.SeedDb
{
    internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(DataSeed);
        }

        private static Genre[] DataSeed
            => [
                new Genre(){
                    Id = 1,
                    Name = "Fantasy",
                },
                new Genre(){
                    Id = 2,
                    Name = "Science Fiction",
                },
                new Genre(){
                    Id = 3,
                    Name = "Dystopian",
                },
                new Genre(){
                    Id = 4,
                    Name = "Romance",
                },
                new Genre(){
                    Id = 5,
                    Name = "Mystery",
                },
                new Genre(){
                    Id = 6,
                    Name = "Thriller",
                },
                new Genre(){
                    Id = 7,
                    Name = "Historical Fiction",
                },
                new Genre(){
                    Id = 8,
                    Name = "Literary Fiction",
                },
                new Genre(){
                    Id = 9,
                    Name = "Adventure",
                },
                new Genre(){
                    Id = 10,
                    Name = "Young Adult (YA)",
                },
                new Genre(){
                    Id = 11,
                    Name = "Children’s",
                },
                new Genre(){
                    Id = 12,
                    Name = "Horror",
                },
                new Genre(){
                    Id = 13,
                    Name = "Biography",
                },
                new Genre(){
                    Id = 14,
                    Name = "Autobiography",
                },
                new Genre(){
                    Id = 15,
                    Name = "Memoir",
                },
                new Genre(){
                    Id = 16,
                    Name = "Non-Fiction",
                },
                new Genre(){
                    Id = 17,
                    Name = "Self-Help",
                },
                new Genre(){
                    Id = 18,
                    Name = "Travel",
                },
                new Genre(){
                    Id = 19,
                    Name = "Cookbooks",
                },
                new Genre(){
                    Id = 20,
                    Name = "Poetry",
                },
                new Genre(){
                    Id = 21,
                    Name = "Graphic Novels",
                },
                new Genre(){
                    Id = 22,
                    Name = "Classic Literature",
                },
                new Genre(){
                    Id = 23,
                    Name = "Satire",
                },
                new Genre(){
                    Id = 24,
                    Name = "Humor",
                },
                new Genre(){
                    Id = 25,
                    Name = "Psychological Fiction",
                },
                new Genre(){
                    Id = 26,
                    Name = "Crime",
                },
                new Genre(){
                    Id = 27,
                    Name = "Western",
                },
                new Genre(){
                    Id = 28,
                    Name = "Historical Romance",
                },
                new Genre(){
                    Id = 29,
                    Name = "Contemporary Fiction",
                },
                new Genre(){
                    Id = 30,
                    Name = "Magical Realism",
                }
            ];
    }
}