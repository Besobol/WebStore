using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Infrastructure.Data.Models
{
    [Comment("Mapping table for Publisher and Book")]
    [PrimaryKey(nameof(PublisherId), nameof(BookId))]
    public class PublisherBook
    {
        [Comment("Publisher Identifier")]
        public int PublisherId { get; set; }
        [ForeignKey(nameof(PublisherId))]
        public Publisher Publisher { get; set; } = null!;

        [Comment("Book Identifier")]
        public int BookId { get; set; }
        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; } = null!;
    }
}