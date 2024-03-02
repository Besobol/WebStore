using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static WebStore.Infrastructure.DataConstants.DataConstants.Store;

namespace WebStore.Infrastructure.Models
{
    [Comment("Book Store")]
    public class Store
    {
        [Key]
        [Comment("Store Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Store Name")]
        public required string Name { get; set; }

        [MaxLength(WebsiteMaxLength)]
        [Comment("Store Website")]
        public string? Website { get; set; }

        public List<StoreBook> StoresBooks { get; set; } = new();
    }
}
