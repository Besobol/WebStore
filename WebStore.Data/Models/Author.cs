using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static WebStore.Infrastructure.DataConstants.DataConstants.Author;

namespace WebStore.Infrastructure.Models
{
    [Comment("Book Author")]
    public class Author
    {
        [Key]
        [Comment("Author Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Author Name")]
        public required string Name { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [Comment("Author Description")]
        public required string Description { get; set; }

        public List<AuthorBook> AuthorsBooks { get; set; } = new();
    }
}
