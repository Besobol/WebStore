using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Infrastructure.Models
{
    [Comment("Mapping table for Genre and Book")]
    [PrimaryKey(nameof(GenreId),nameof(BookId))]
    public class GenreBook
    {
        [Comment("Genre Identifier")]
        public int GenreId { get; set; }
        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; } = null!;

        [Comment("Book Identifier")]
        public int BookId { get; set; }
        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; } = null!;
    }
}