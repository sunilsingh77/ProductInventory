using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProductRegistration.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please Enter Name..")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Product Amount..")]
        [Display(Name = "Amount")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Please Enter Quantity..")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Please Enter Brand...")]
        [Display(Name = "Brand")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Select the product image...")]
        [Display(Name = "Image")]
        public string Image { get; set; }
        
        [Display(Name = "IsActive")]
        public bool IsActive { get; set; }
    }
}
