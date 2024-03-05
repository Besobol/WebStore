using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Infrastructure.Data.Models
{
    [Comment("Mapping table for Store and Book")]
    [PrimaryKey(nameof(StoreId), nameof(BookId))]
    public class StoreBook
    {
        [Comment("Store Identifier")]
        public int StoreId { get; set; }
        [ForeignKey(nameof(StoreId))]
        public Store Store { get; set; } = null!;

        [Comment("Book Identifier")]
        public int BookId { get; set; }
        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; } = null!;
    }
}