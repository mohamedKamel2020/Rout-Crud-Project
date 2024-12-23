using System.ComponentModel.DataAnnotations;

namespace Demo.PL.ViewModels
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "Email is required")]
		[EmailAddress(ErrorMessage = "invalid Email")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is required")]
		[DataType(DataType.Password)]
		//[MinLength(6,ErrorMessage ="Minimum password Length is 6")]
		public string Password { get; set; }
		public bool RememberMe { get; set; }
	}
}
