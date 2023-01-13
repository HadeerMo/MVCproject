using System.ComponentModel.DataAnnotations;

namespace Demo.PL.Models
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage ="Email is required")]
		[EmailAddress(ErrorMessage ="Invalid Email")]
		public string Email { get; set; }
		[Required(ErrorMessage ="Passwod is required")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Passwod is required")]
        [DataType(DataType.Password)]
		[Compare("Password",ErrorMessage ="Confirm password does not match password")]
        public string ConfirmPassword { get; set; }
		public bool IsAgree { get; set; }
	}
}
