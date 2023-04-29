using System.ComponentModel.DataAnnotations;

namespace QuarterlySalesApp.Models.Validation
{
    public class GreaterThanAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext ctx)
        {
            return ValidationResult.Success;
        }
    }
}
