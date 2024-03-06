using System.ComponentModel.DataAnnotations;
using static WebStore.Infrastructure.DataConstants.DataConstants;
using static WebStore.Core.Constants.ErrorMessages;
using static WebStore.Core.Constants.ValidationConstants;

namespace WebStore.Core.Models
{
    public class StoreModel
    {
        [Required]
        [StringLength(
            Store.NameMaxLength,
            MinimumLength = Store.NameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public required string Name { get; set; }

        [Required]
        [RegularExpression(WebsiteRegex)]
        public required string Website { get; set; }
    }
}
