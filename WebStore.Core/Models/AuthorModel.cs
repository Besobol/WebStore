using System.ComponentModel.DataAnnotations;
using static WebStore.Infrastructure.DataConstants.DataConstants;
using static WebStore.Core.Constants.ErrorMessages;

namespace WebStore.Core.Models
{
    public class AuthorModel
    {
        [Required]
        [StringLength(
            Author.NameMaxLength,
            MinimumLength = Author.NameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public required string Name { get; set; }

        [Required]
        [StringLength(
            Author.DescriptionMaxLength,
            MinimumLength = Author.DescriptionMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public required string Description { get; set; }
    }
}
