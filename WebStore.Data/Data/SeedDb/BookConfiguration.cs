using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Models;

namespace WebStore.Infrastructure.Data.SeedDb
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(DataSeed);
        }

        private static Book[] DataSeed
            => [
                new Book(){
                    Id = 1,
                    Title = "The Sunlit Man",
                    Summery = "From #1 New York Times bestselling author Brandon Sanderson—creator of The Stormlight Archive, the Mistborn Saga, and countless bestselling works of science fiction and fantasy—comes this standalone novel showing a rare glimpse of a future Cosmere universe.\r\n\r\nRunning. Putting distance between himself and the relentless Night Brigade has been Nomad’s strategy for years. Staying one or two steps ahead of his pursuers by skipping through the Cosmere from one world to the next.\r\n\r\nBut now, his powers too depleted to escape, Nomad finds himself trapped on Canticle, a planet that will kill anyone who doesn’t keep moving. Fleeing the fires of a sunrise that melts the very stones, he is instantly caught up in the struggle between a heartless tyrant and the brave rebels who defy him.\r\n\r\nFailure means a quick death, incinerated by the sun… or a lifetime as a mindless slave. Tormented by the consequences of his past, Nomad must fight not only for his survival—but also for his very soul.",
                    Price = 29.99m,
                    ImgPath = "https://mpd-biblio-covers.imgix.net/9781250899712.jpg?w=900"
                    // Tor
                    // Fantasy
                },
                new Book(){
                    Id = 2,
                    Title = "The Bezzle",
                    Summery = "The year is 2006. Martin Hench is at the top of his game as a self-employed forensic accountant, a veteran of the long guerrilla war between people who want to hide money, and people who want to find it. He spends his downtime on Catalina Island, where scenic, imported bison wander the bluffs and frozen, reheated fast food burgers cost 25$. Wait, what? When Marty disrupts a seemingly innocuous scheme during a vacation on Catalina Island, he has no idea he’s kicked off a chain of events that will overtake the next decade of his life.\r\n\r\nMartin has made his most dangerous mistake yet: trespassed into the playgrounds of the ultra-wealthy and spoiled their fun. To them, money is a tool, a game, and a way to keep score, and they’ve found their newest mark—California’s Department of Corrections. Secure in the knowledge that they’re living behind far too many firewalls of shell companies and investors ever to be identified, they are interested not in the lives they ruin, but only in how much money they can extract from the government and the hundreds of thousands of prisoners they have at their mercy.\r\n\r\nA seething rebuke of the privatized prison system that delves deeply into the arcane and baroque financial chicanery involved in the 2008 financial crash, The Bezzle is a sizzling follow-up to Red Team Blues.",
                    Price = 27.99m,
                    ImgPath = "https://mpd-biblio-covers.imgix.net/9781250865878.jpg?w=900"
                    // Tor
                    // Thriller
                },
                new Book(){
                    Id = 3,
                    Title = "Unlimited Memory: How to Use Advanced Learning Strategies to Learn Faster, Remember More and be More Productive",
                    Summery = "Do you ever feel like you're too busy, too stressed or just too distracted to concentrate and get work done?\r\n\r\nIn Unlimited Memory, you'll learn how the world's best memory masters get themselves to concentrate at will, anytime they want. When you can easily focus and concentrate on the task at hand, and store and recall useful information, you can easily double your productivity and eliminate wasted time, stress and mistakes at work.\r\n\r\nIn this book, you'll find all the tools, strategies and techniques you need to improve your memory.\r\n\r\nHere’s just a taste of the memory methods in this book:\r\nThe 3 bad habits that keep you from easily remembering important information\r\nHow a simple pattern of thinking can stop you from imprinting and remembering key facts, figures and ideas, and how to break this old pattern so you’ll never again be known as someone with a “bad memory”\r\nHow to master your attention so you can focus and concentrate longer, even during challenging or stressful situations\r\nHow to use your car to remember anything you want (like long lists or information you need to remember for your studies or personal life) without writing anything down\r\nSimple methods that allow you to nail down tough information or complex concepts quickly and easily\r\nHow to combine your long-term memory (things you already know and will never forget) and short-term memory (information you want to remember right now) to create instant recall for tests, presentations and important projects\r\nThe simple, invisible mental technique for remembering names without social awkwardness or anxiety\r\nHow using your imagination to bring boring information to life can help you dramatically improve your attention span and recall\r\nAn incredible strategy for remembering numbers (the same system Kevin used to remember Pi to 10,000 digits and beat the world memory record by 14 minutes)\r\nHow to use a mental map to lock in and connect hundreds or even thousands of ideas in your long-term memory (this method will allow you to become a leading expert in your field faster than you ever dreamed possible)\r\n\r\nIf you're ready to harness the incredible power of your mind to remember more in less time, this book is for you.",
                    Price = 16.49m,
                    ImgPath = "https://m.media-amazon.com/images/I/71f4yosQq2L._SY466_.jpg"
                    // TCK
                    // Self-Help
                },
                new Book(){
                    Id = 4,
                    Title = "I Let You Fall",
                    Summery = "On a summer night in London, art teacher Eve Chapman finds herself in a hospital emergency room. She watches surgeons desperately operate on a young woman with a terrible head injury. But when the bandages are removed, Eve is horrified to find her own body on the operating table.\r\n\r\nTrapped in a coma, Eve struggles to cope with the fact that no matter how hard she tries, her family and friends cannot see or hear her. But then she meets Luca Diaz, a handsome and comatose lawyer who can see her. He takes Eve under his wing and teaches her how to use her new abilities to help the living.\r\n\r\nAs the weeks pass, Eve struggles to find a way back to her body and to Nathan, the man she loves. But the more time she spends with Luca, the more she wonders if her old life is worth going back to at all.",
                    Price = 14.99m,
                    ImgPath = "https://m.media-amazon.com/images/I/61zy2nK5mVL._SY466_.jpg"
                    // TCK
                    // Romance
                },
                new Book(){
                    Id = 5,
                    Title = "Max in the House of Spies",
                    Summery = "Max Bretzfeld doesn’t want to move to London.\r\n\r\nLeaving home is hard and Max is alone for the first time in his life. But not for long. Max is surprised to discover that he’s been joined by two unexpected traveling companions, one on each shoulder, a kobold and a dybbuk named Berg and Stein.\r\n\r\nGermany is becoming more and more dangerous for Jewish families, but Max is determined to find a way back home, and back to his parents. He has a plan to return to Berlin. It merely involves accomplishing the impossible: becoming a British spy.\r\n\r\nThe first book in a duology, Max in the House of Spies is a thought-provoking World War II story as only acclaimed storyteller Adam Gidwitz can tell it—fast-paced and hilarious, with a dash of magic and a lot of heart.",
                    Price = 18.99m,
                    ImgPath = "https://images2.penguinrandomhouse.com/cover/9780593112083"
                    // Penguin Random House
                    // Children’s
                },
                new Book(){
                    Id = 6,
                    Title = "Snowglobe",
                    Summery = "Enclosed under a vast dome, Snowglobe is the last place on Earth that’s warm. Outside Snowglobe is a frozen wasteland, and every day, citizens face the icy world to get to their jobs at the power plant, where they produce the energy Snowglobe needs. Their only solace comes in the form of twenty-four-hour television programming streamed directly from the domed city.\r\n\r\nThe residents of Snowglobe have everything: fame, fortune, and above all, safety from the desolation outside their walls. In exchange, their lives are broadcast to the less fortunate outside, who watch eagerly, hoping for the chance to one day become actors themselves.\r\n\r\nChobahm lives for the time she spends watching the shows produced inside Snowglobe. Her favorite? Goh Around, starring Goh Haeri, Snowglobe’s biggest star—and, it turns out, the key to getting Chobahm her dream life.\r\n\r\nBecause Haeri is dead, and Chobahm has been chosen to take her place. Only, life inside Snowglobe is nothing like what you see on television. Reality is a lie, and truth seems to be forever out of reach.\r\n\r\nTranslated for the first time into English from the original Korean, Snowglobe is a groundbreaking exploration of personal identity, and the future of the world as we know it. It is the winner of the Changbi X Kakaopage Young Adult Novel Award.\r\n\r\n",
                    Price = 20.99m,
                    ImgPath = "https://images1.penguinrandomhouse.com/cover/9780593484975"
                    // Penguin Random House
                    // Young Adult (YA)
                },
                new Book(){
                    Id = 7,
                    Title = "Sasquatch and the Muckleshoot",
                    Summery = "All Elliot wants is a nice, normal day at school. All Uchenna wants is an adventure. Guess whose wish comes true?\r\n\r\nProfessor Fauna whisks the kids—and Jersey, of course—off to the Muckleshoot territory in Washington, where film crews have suddenly descended en masse to expose Bigfoot to the world, and the Schmoke logging company is bringing in some awfully large machinery.\r\n\r\nCan the Unicorn Rescue Society escape the blades of the Schmokes’ chain saws? Outsmart a cable news team? And are those big, hairy creatures running through the forest really Bigfoot?\r\n\r\n",
                    Price = 8.99m,
                    ImgPath = "https://images1.penguinrandomhouse.com/cover/9780735231788"
                    // Penguin Random House
                    // Children’s
                }
            ];
    }
}
