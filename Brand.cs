using System.ComponentModel.DataAnnotations;

namespace TopSpeed.Web.Models
{
    public class Brand
    {
        [Key]
        public Guid Id { get; set; }  

        [Required]
        public string Name { get; set; }
        [Display(Name="Manufacturing Year")]
        public int ManufacturingYear { get; set; }
        [Display(Name = "Brand Logo")]
        public string BrandLogo { get; set; }
    }
}
