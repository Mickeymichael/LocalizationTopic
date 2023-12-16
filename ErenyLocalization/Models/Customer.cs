using System.ComponentModel.DataAnnotations;

namespace ErenyLocalization.Models
{
    public class Customer
    {
        [Display(Name ="Name")]
        [Required]
        [UniqueName]
        public string Name { get; set; }

        [Display(Name ="Address")]
        [Required]
        [Range(3,50)]
        public string Address { get; set; }
    }
}
