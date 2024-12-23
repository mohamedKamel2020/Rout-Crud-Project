using System.ComponentModel.DataAnnotations;

namespace Demo.PL.ViewModels
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required(ErrorMessage ="confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("NewPassword",ErrorMessage ="Confirm Password does not match Password")]
        public string ConfirmPassword { get; set;}
    }
}
