using System.ComponentModel.DataAnnotations;

namespace ErenyLocalization.Models
{
    public class UniqueNameAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return base.IsValid(value, validationContext);
        }
    }
}
