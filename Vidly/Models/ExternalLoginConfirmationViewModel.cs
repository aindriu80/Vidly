using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Driving Licence")]
        public string DrivingLicence { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
    }
}