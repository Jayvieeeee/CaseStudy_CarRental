using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
