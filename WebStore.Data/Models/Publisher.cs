using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static WebStore.Infrastructure.DataConstants.DataConstants.Publisher;

namespace WebStore.Infrastructure.Models
{
    [Comment("Book Publisher")]
    public class Publisher
    {
        [Key]
        [Comment("Publisher Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Publisher Name")]
        public required string Name { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [Comment("Publisher Description")]
        public required string Description { get; set; }

        public List<PublisherBook> PublishersBooks { get; set; } = new();
    }
}
