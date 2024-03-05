using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static WebStore.Infrastructure.DataConstants.DataConstants.Book;

namespace WebStore.Infrastructure.Data.Models
{
    [Comment("Book")]
    public class Book
    {
        [Key]
        [Comment("Book Identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLength)]
        [Comment("Book Title")]
        public required string Title { get; set; }

        [Required]
        [StringLength(SummeryMaxLength)]
        [Comment("Book Summery")]
        public required string Summery { get; set; }

        [Required]
        [Comment("Book Price")]
        [Precision(PricePrecisionWhole, PricePrecisionDecimal)]
        public required decimal Price { get; set; }

        [Required]
        [Comment("Path to Book Images")]
        public required string ImgPath { get; set; }

        public List<AuthorBook> AuthorsBooks { get; set; } = new();

        public List<StoreBook> StoresBooks { get; set; } = new();

        public List<PublisherBook> PublishersBooks { get; set; } = new();

        public List<GenreBook> GenresBooks { get; set; } = new();
    }
}
