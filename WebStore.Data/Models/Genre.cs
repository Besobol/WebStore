using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static WebStore.Infrastructure.DataConstants.DataConstants.Genre;

namespace WebStore.Infrastructure.Models
{
    [Comment("Book Genre")]
    public class Genre
    {
        [Key]
        [Comment("Genre Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Genre Name")]
        public required string Name { get; set; }

        public List<GenreBook> GenresBooks { get; set; } = new();
    }
}
