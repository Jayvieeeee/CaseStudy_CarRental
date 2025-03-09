using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class ResetPasswordViewModel
    {

        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string NewPassword { get; set; }
    }
}
