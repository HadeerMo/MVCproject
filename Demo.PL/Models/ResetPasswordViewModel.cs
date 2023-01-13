using System.ComponentModel.DataAnnotations;

namespace Demo.PL.Models
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Passwod is required")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Confirm Passwod is required")]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "Confirm password does not match password")]
        public string ConfirmPassword { get; set; }
    }
}
