using System.ComponentModel.DataAnnotations;
using static WebStore.Infrastructure.DataConstants.DataConstants;
using static WebStore.Core.Constants.ErrorMessages;

namespace WebStore.Core.Models
{
    public class BookModel
    {
        [Required]
        [StringLength(
            Book.TitleMaxLength,
            MinimumLength = Book.TitleMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [DataType(DataType.Text)]
        public required string Title { get; set; }

        [Required]
        [StringLength(
            Book.SummeryMaxLength,
            MinimumLength = Book.SummeryMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [DataType(DataType.MultilineText)]
        public required string Summery { get; set; }

        [Required]
        [Range(0,999)]
        [DataType(DataType.Currency)]
        public required decimal Price { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public required string ImgPath { get; set; }
    }
}
