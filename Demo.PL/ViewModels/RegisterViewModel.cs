using System.ComponentModel.DataAnnotations;

namespace Demo.PL.ViewModels
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage ="Email is required")]
		[EmailAddress(ErrorMessage ="invalid Email")]
		public string Email { get; set; }
		
		[Required(ErrorMessage = "Password is required")]
		[DataType(DataType.Password)]
		//[MinLength(6,ErrorMessage ="Minimum password Length is 6")]
		public string Password { get; set; }

		[Required(ErrorMessage ="Confirm Password is required")]
		[Compare("Password",ErrorMessage ="Confirm Password does not match Password")]
		[DataType(DataType.Password)]
		public string ConfirmPassword { get; set; }
		
		public bool IsAgree { get; set; }
	}
}
