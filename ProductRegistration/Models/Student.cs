using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProductRegistration.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Please Enter Name..")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter AadharcardNumber..")]
        [Display(Name = "AadharcardNumber")]
        public string AadharcardNumber { get; set; }

        [Required(ErrorMessage = "Please Enter ContactNumber..")]
        [Display(Name = "ContactNumber")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Please Enter EmailId...")]
        [Display(Name = "EmailId")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Select the Gender...")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Select the DOB...")]
        [Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }

        [Display(Name = "Parent Name")]
        public string ParentName { get; set; }

        [Display(Name = "Parent Contact")]
        public string ParentContact { get; set; }
    }
}
