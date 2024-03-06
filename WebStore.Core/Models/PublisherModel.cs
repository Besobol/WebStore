﻿using System.ComponentModel.DataAnnotations;
using static WebStore.Infrastructure.DataConstants.DataConstants;
using static WebStore.Core.Constants.ErrorMessages;

namespace WebStore.Core.Models
{
    public class PublisherModel
    {
        [Required]
        [StringLength(
            Publisher.NameMaxLength,
            MinimumLength = Publisher.NameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public required string Name { get; set; }

        [Required]
        [StringLength(
            Publisher.DescriptionMaxLength,
            MinimumLength = Publisher.DescriptionMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public required string Description { get; set; }
    }
}
