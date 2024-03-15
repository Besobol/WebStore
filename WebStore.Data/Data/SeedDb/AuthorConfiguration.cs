using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Models;

namespace WebStore.Infrastructure.Data.SeedDb
{
    internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(DataSeed);
        }

        private static Author[] DataSeed 
            => [
                new Author(){
                    Id = 1,
                    Name = "Brandon Sanderson",
                    Description = "Brandon Sanderson, born on December 19, 1975, is an American author known for his high fantasy and science fiction works. He’s famous for the Cosmere universe, where most of his novels, including the Mistborn series and The Stormlight Archive, are se1. Sanderson also completed Robert Jordan’s The Wheel of Time series. He has written several young adult and juvenile series, and has created graphic novel series like White Sand and Dark One.",
                },
                new Author(){
                    Id = 2,
                    Name = "Cory Doctorow",
                    Description = "Cory Doctorow is a Canadian-British author known for his works in science fiction and activism. He has written novels like “Little Brother”, “Walkaway”, and “In Real Life” that explore themes of dystopia, surveillance, and freedom. Doctorow’s writings often reflect his advocacy for civil liberties and digital rights. His work has been recognized with several awards.",
                },
                new Author(){
                    Id = 3,
                    Name = "Kevin Horsley",
                    Description = "For over 30 years, Kevin Horsley has been analyzing the mind and memory and its capacity for brilliance. He is one of only a few people in the world to have received the title International Grandmaster of Memory. He is a World Memory Championship medalist and a two-time World Record holder for The Everest of memory tests. Kevin is also an author of four books and a times table game designer with the Serious Games Institute at North-West University Vaal Campus.",
                },
                new Author(){
                    Id = 4,
                    Name = "Sara Downing",
                    Description = "Sara Downing is an award-winning author of several genres, including romance and historical fiction. More recently she has become fascinated with the supernatural. Her first book in this genre, 'The Lost Boy', was followed up by 'I Let You Fall', which was the WINNER in the RNA Romantic Novel Awards 2023, Fantasy Romantic Novel category.",
                },
                new Author(){
                    Id = 5,
                    Name = "Adam Gidwitz",
                    Description = "Bestselling author Adam Gidwitz was a teacher for eight years. He told countless stories to his students, who then demanded he write his first book, A Tale Dark & Grimm. Adam has since written two companion novels, In a Glass Grimmly and The Grimm Conclusion. He is also the author of The Inquisitor’s Tale, which won the Newbery Honor, and The Unicorn Rescue Society series. Adam still tells creepy, funny fairy tales live to kids on his podcast Grimm, Grimmer, Grimmest—and at schools around the world. He lives in Brooklyn with his wife, daughter, and dog, Lucy Goosey.",
                },
                new Author(){
                    Id = 6,
                    Name = "Soyoung Park",
                    Description = "Soyoung Park majored in information and communication at university and has worked as a reporter. She is a winner of the Original Story Award and the Changbi X Kakaopage Young Adult Novel Award. She’s the author of the Snowglobe duology.",
                }
            ];
    }
}
