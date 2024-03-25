using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Brandon Sanderson, born on December 19, 1975, is an American author known for his high fantasy and science fiction works. He’s famous for the Cosmere universe, where most of his novels, including the Mistborn series and The Stormlight Archive, are se1. Sanderson also completed Robert Jordan’s The Wheel of Time series. He has written several young adult and juvenile series, and has created graphic novel series like White Sand and Dark One.", "Brandon Sanderson" },
                    { 2, "Cory Doctorow is a Canadian-British author known for his works in science fiction and activism. He has written novels like “Little Brother”, “Walkaway”, and “In Real Life” that explore themes of dystopia, surveillance, and freedom. Doctorow’s writings often reflect his advocacy for civil liberties and digital rights. His work has been recognized with several awards.", "Cory Doctorow" },
                    { 3, "For over 30 years, Kevin Horsley has been analyzing the mind and memory and its capacity for brilliance. He is one of only a few people in the world to have received the title International Grandmaster of Memory. He is a World Memory Championship medalist and a two-time World Record holder for The Everest of memory tests. Kevin is also an author of four books and a times table game designer with the Serious Games Institute at North-West University Vaal Campus.", "Kevin Horsley" },
                    { 4, "Sara Downing is an award-winning author of several genres, including romance and historical fiction. More recently she has become fascinated with the supernatural. Her first book in this genre, 'The Lost Boy', was followed up by 'I Let You Fall', which was the WINNER in the RNA Romantic Novel Awards 2023, Fantasy Romantic Novel category.", "Sara Downing" },
                    { 5, "Bestselling author Adam Gidwitz was a teacher for eight years. He told countless stories to his students, who then demanded he write his first book, A Tale Dark & Grimm. Adam has since written two companion novels, In a Glass Grimmly and The Grimm Conclusion. He is also the author of The Inquisitor’s Tale, which won the Newbery Honor, and The Unicorn Rescue Society series. Adam still tells creepy, funny fairy tales live to kids on his podcast Grimm, Grimmer, Grimmest—and at schools around the world. He lives in Brooklyn with his wife, daughter, and dog, Lucy Goosey.", "Adam Gidwitz" },
                    { 6, "Soyoung Park majored in information and communication at university and has worked as a reporter. She is a winner of the Original Story Award and the Changbi X Kakaopage Young Adult Novel Award. She’s the author of the Snowglobe duology.", "Soyoung Park" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "ImgPath", "Price", "Summery", "Title" },
                values: new object[,]
                {
                    { 1, "https://mpd-biblio-covers.imgix.net/9781250899712.jpg?w=900", 29.99m, "From #1 New York Times bestselling author Brandon Sanderson—creator of The Stormlight Archive, the Mistborn Saga, and countless bestselling works of science fiction and fantasy—comes this standalone novel showing a rare glimpse of a future Cosmere universe.\r\n\r\nRunning. Putting distance between himself and the relentless Night Brigade has been Nomad’s strategy for years. Staying one or two steps ahead of his pursuers by skipping through the Cosmere from one world to the next.\r\n\r\nBut now, his powers too depleted to escape, Nomad finds himself trapped on Canticle, a planet that will kill anyone who doesn’t keep moving. Fleeing the fires of a sunrise that melts the very stones, he is instantly caught up in the struggle between a heartless tyrant and the brave rebels who defy him.\r\n\r\nFailure means a quick death, incinerated by the sun… or a lifetime as a mindless slave. Tormented by the consequences of his past, Nomad must fight not only for his survival—but also for his very soul.", "The Sunlit Man" },
                    { 2, "https://mpd-biblio-covers.imgix.net/9781250865878.jpg?w=900", 27.99m, "The year is 2006. Martin Hench is at the top of his game as a self-employed forensic accountant, a veteran of the long guerrilla war between people who want to hide money, and people who want to find it. He spends his downtime on Catalina Island, where scenic, imported bison wander the bluffs and frozen, reheated fast food burgers cost 25$. Wait, what? When Marty disrupts a seemingly innocuous scheme during a vacation on Catalina Island, he has no idea he’s kicked off a chain of events that will overtake the next decade of his life.\r\n\r\nMartin has made his most dangerous mistake yet: trespassed into the playgrounds of the ultra-wealthy and spoiled their fun. To them, money is a tool, a game, and a way to keep score, and they’ve found their newest mark—California’s Department of Corrections. Secure in the knowledge that they’re living behind far too many firewalls of shell companies and investors ever to be identified, they are interested not in the lives they ruin, but only in how much money they can extract from the government and the hundreds of thousands of prisoners they have at their mercy.\r\n\r\nA seething rebuke of the privatized prison system that delves deeply into the arcane and baroque financial chicanery involved in the 2008 financial crash, The Bezzle is a sizzling follow-up to Red Team Blues.", "The Bezzle" },
                    { 3, "https://m.media-amazon.com/images/I/71f4yosQq2L._SY466_.jpg", 16.49m, "Do you ever feel like you're too busy, too stressed or just too distracted to concentrate and get work done?\r\n\r\nIn Unlimited Memory, you'll learn how the world's best memory masters get themselves to concentrate at will, anytime they want. When you can easily focus and concentrate on the task at hand, and store and recall useful information, you can easily double your productivity and eliminate wasted time, stress and mistakes at work.\r\n\r\nIn this book, you'll find all the tools, strategies and techniques you need to improve your memory.\r\n\r\nHere’s just a taste of the memory methods in this book:\r\nThe 3 bad habits that keep you from easily remembering important information\r\nHow a simple pattern of thinking can stop you from imprinting and remembering key facts, figures and ideas, and how to break this old pattern so you’ll never again be known as someone with a “bad memory”\r\nHow to master your attention so you can focus and concentrate longer, even during challenging or stressful situations\r\nHow to use your car to remember anything you want (like long lists or information you need to remember for your studies or personal life) without writing anything down\r\nSimple methods that allow you to nail down tough information or complex concepts quickly and easily\r\nHow to combine your long-term memory (things you already know and will never forget) and short-term memory (information you want to remember right now) to create instant recall for tests, presentations and important projects\r\nThe simple, invisible mental technique for remembering names without social awkwardness or anxiety\r\nHow using your imagination to bring boring information to life can help you dramatically improve your attention span and recall\r\nAn incredible strategy for remembering numbers (the same system Kevin used to remember Pi to 10,000 digits and beat the world memory record by 14 minutes)\r\nHow to use a mental map to lock in and connect hundreds or even thousands of ideas in your long-term memory (this method will allow you to become a leading expert in your field faster than you ever dreamed possible)\r\n\r\nIf you're ready to harness the incredible power of your mind to remember more in less time, this book is for you.", "Unlimited Memory: How to Use Advanced Learning Strategies to Learn Faster, Remember More and be More Productive" },
                    { 4, "https://m.media-amazon.com/images/I/61zy2nK5mVL._SY466_.jpg", 14.99m, "On a summer night in London, art teacher Eve Chapman finds herself in a hospital emergency room. She watches surgeons desperately operate on a young woman with a terrible head injury. But when the bandages are removed, Eve is horrified to find her own body on the operating table.\r\n\r\nTrapped in a coma, Eve struggles to cope with the fact that no matter how hard she tries, her family and friends cannot see or hear her. But then she meets Luca Diaz, a handsome and comatose lawyer who can see her. He takes Eve under his wing and teaches her how to use her new abilities to help the living.\r\n\r\nAs the weeks pass, Eve struggles to find a way back to her body and to Nathan, the man she loves. But the more time she spends with Luca, the more she wonders if her old life is worth going back to at all.", "I Let You Fall" },
                    { 5, "https://images2.penguinrandomhouse.com/cover/9780593112083", 18.99m, "Max Bretzfeld doesn’t want to move to London.\r\n\r\nLeaving home is hard and Max is alone for the first time in his life. But not for long. Max is surprised to discover that he’s been joined by two unexpected traveling companions, one on each shoulder, a kobold and a dybbuk named Berg and Stein.\r\n\r\nGermany is becoming more and more dangerous for Jewish families, but Max is determined to find a way back home, and back to his parents. He has a plan to return to Berlin. It merely involves accomplishing the impossible: becoming a British spy.\r\n\r\nThe first book in a duology, Max in the House of Spies is a thought-provoking World War II story as only acclaimed storyteller Adam Gidwitz can tell it—fast-paced and hilarious, with a dash of magic and a lot of heart.", "Max in the House of Spies" },
                    { 6, "https://images1.penguinrandomhouse.com/cover/9780593484975", 20.99m, "Enclosed under a vast dome, Snowglobe is the last place on Earth that’s warm. Outside Snowglobe is a frozen wasteland, and every day, citizens face the icy world to get to their jobs at the power plant, where they produce the energy Snowglobe needs. Their only solace comes in the form of twenty-four-hour television programming streamed directly from the domed city.\r\n\r\nThe residents of Snowglobe have everything: fame, fortune, and above all, safety from the desolation outside their walls. In exchange, their lives are broadcast to the less fortunate outside, who watch eagerly, hoping for the chance to one day become actors themselves.\r\n\r\nChobahm lives for the time she spends watching the shows produced inside Snowglobe. Her favorite? Goh Around, starring Goh Haeri, Snowglobe’s biggest star—and, it turns out, the key to getting Chobahm her dream life.\r\n\r\nBecause Haeri is dead, and Chobahm has been chosen to take her place. Only, life inside Snowglobe is nothing like what you see on television. Reality is a lie, and truth seems to be forever out of reach.\r\n\r\nTranslated for the first time into English from the original Korean, Snowglobe is a groundbreaking exploration of personal identity, and the future of the world as we know it. It is the winner of the Changbi X Kakaopage Young Adult Novel Award.\r\n\r\n", "Snowglobe" },
                    { 7, "https://images1.penguinrandomhouse.com/cover/9780735231788", 8.99m, "All Elliot wants is a nice, normal day at school. All Uchenna wants is an adventure. Guess whose wish comes true?\r\n\r\nProfessor Fauna whisks the kids—and Jersey, of course—off to the Muckleshoot territory in Washington, where film crews have suddenly descended en masse to expose Bigfoot to the world, and the Schmoke logging company is bringing in some awfully large machinery.\r\n\r\nCan the Unicorn Rescue Society escape the blades of the Schmokes’ chain saws? Outsmart a cable news team? And are those big, hairy creatures running through the forest really Bigfoot?\r\n\r\n", "Sasquatch and the Muckleshoot" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fantasy" },
                    { 2, "Science Fiction" },
                    { 3, "Dystopian" },
                    { 4, "Romance" },
                    { 5, "Mystery" },
                    { 6, "Thriller" },
                    { 7, "Historical Fiction" },
                    { 8, "Literary Fiction" },
                    { 9, "Adventure" },
                    { 10, "Young Adult (YA)" },
                    { 11, "Children’s" },
                    { 12, "Horror" },
                    { 13, "Biography" },
                    { 14, "Autobiography" },
                    { 15, "Memoir" },
                    { 16, "Non-Fiction" },
                    { 17, "Self-Help" },
                    { 18, "Travel" },
                    { 19, "Cookbooks" },
                    { 20, "Poetry" },
                    { 21, "Graphic Novels" },
                    { 22, "Classic Literature" },
                    { 23, "Satire" },
                    { 24, "Humor" },
                    { 25, "Psychological Fiction" },
                    { 26, "Crime" },
                    { 27, "Western" },
                    { 28, "Historical Romance" },
                    { 29, "Contemporary Fiction" },
                    { 30, "Magical Realism" }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Tor Books, the flagship imprint of the Tor Publishing Group, is renowned for publishing an extensive and diverse array of science fiction and fantasy titles. As one of the leading publishers in this genre, Tor’s mission is to bring readers out-of-this-world genre fiction that fuels the imagination. Whether you’re exploring distant galaxies, magical realms, or thrilling adventures, Tor Books has something for every speculative fiction enthusiast.", "Tor" },
                    { 2, "TCK Publishing is an independent book publisher that specializes in both fiction and nonfiction. They publish a wide range of eBooks, print books, and audiobooks across various genres and niches. Their mission is to bring meaningful and inspirational stories to readers around the world.", "TCK" },
                    { 3, "Penguin Random House is the international home to more than 300 editorially and creatively independent publishing imprints. Our mission is to ignite a universal passion for reading by creating books for everyone. We believe that books, and the stories and ideas they hold, have the unique capacity to connect us, change us, and carry us toward a better future for generations to come.", "Penguin Random House" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "Name", "Website" },
                values: new object[,]
                {
                    { 1, "Orange", "https://www.orangecenter.bg/" },
                    { 2, "Bookpoint", "https://www.bookpoint.bg/" },
                    { 3, "Ciela", "https://www.ciela.com/" }
                });

            migrationBuilder.InsertData(
                table: "AuthorsBooks",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 5, 7 },
                    { 6, 6 }
                });

            migrationBuilder.InsertData(
                table: "GenresBooks",
                columns: new[] { "BookId", "GenreId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 4 },
                    { 2, 6 },
                    { 6, 10 },
                    { 5, 11 },
                    { 7, 11 },
                    { 3, 17 }
                });

            migrationBuilder.InsertData(
                table: "PublishersBooks",
                columns: new[] { "BookId", "PublisherId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 3 }
                });

            migrationBuilder.InsertData(
                table: "StoresBooks",
                columns: new[] { "BookId", "StoreId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 1, 3 },
                    { 2, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorsBooks",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AuthorsBooks",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AuthorsBooks",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AuthorsBooks",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "AuthorsBooks",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "AuthorsBooks",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "AuthorsBooks",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "GenresBooks",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "GenresBooks",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "GenresBooks",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "GenresBooks",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "GenresBooks",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "GenresBooks",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 7, 11 });

            migrationBuilder.DeleteData(
                table: "GenresBooks",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "PublishersBooks",
                keyColumns: new[] { "BookId", "PublisherId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PublishersBooks",
                keyColumns: new[] { "BookId", "PublisherId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PublishersBooks",
                keyColumns: new[] { "BookId", "PublisherId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "PublishersBooks",
                keyColumns: new[] { "BookId", "PublisherId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "PublishersBooks",
                keyColumns: new[] { "BookId", "PublisherId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "PublishersBooks",
                keyColumns: new[] { "BookId", "PublisherId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "PublishersBooks",
                keyColumns: new[] { "BookId", "PublisherId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "StoresBooks",
                keyColumns: new[] { "BookId", "StoreId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StoresBooks",
                keyColumns: new[] { "BookId", "StoreId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "StoresBooks",
                keyColumns: new[] { "BookId", "StoreId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "StoresBooks",
                keyColumns: new[] { "BookId", "StoreId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "StoresBooks",
                keyColumns: new[] { "BookId", "StoreId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "StoresBooks",
                keyColumns: new[] { "BookId", "StoreId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "StoresBooks",
                keyColumns: new[] { "BookId", "StoreId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
