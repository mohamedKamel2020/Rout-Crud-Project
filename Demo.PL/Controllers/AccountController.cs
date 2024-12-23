using Demo.DAL.Entities;
using Demo.PL.Helpers;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;

		private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
			_userManager = userManager;
        }
        
		#region Register

        public  IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
		{
			if (ModelState.IsValid)
			{
				var user = new ApplicationUser()
				{
					UserName = registerViewModel.Email.Split('@')[0],
					Email = registerViewModel.Email,
					IsAgree = registerViewModel.IsAgree,
				};
				var result= await _userManager.CreateAsync(user,registerViewModel.Password);
			    if(result.Succeeded)
				{
					return RedirectToAction("Login");
				}
			    foreach(var error in result.Errors)
				{
					ModelState.AddModelError(string.Empty, error.Description);
				}
			}
			return View(registerViewModel);
		}
		#endregion

		#region Login
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Login(LoginViewModel loginViewModel)
		{
			if (ModelState.IsValid) 
			{
				var user = await _userManager.FindByEmailAsync(loginViewModel.Email);
				if (user != null)
				{
					bool flag = await _userManager.CheckPasswordAsync(user, loginViewModel.Password);
					if (flag)
					{
						var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, loginViewModel.RememberMe, false);
						if (result.Succeeded)
						{
							return RedirectToAction("Index", "Department");
						}
					}
					ModelState.AddModelError(string.Empty, "Password is not correct");
				}
				else
				{
					ModelState.AddModelError(string.Empty, "Email is not Existed");
				}
			}

			return View(loginViewModel);
		}
		#endregion

		#region Sign Out
		public new async Task<IActionResult> SignOut()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction(nameof(Login));
		}


		#endregion

		#region Forget Password
		public IActionResult ForgetPassword()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> SendEmail(ForgetPasswordViewModel forgetPasswordViewModel)
		{
			if (ModelState.IsValid)
			{
		 		var user = await _userManager.FindByEmailAsync(forgetPasswordViewModel.Email);
				if (user != null)
				{
					var token = await _userManager.GeneratePasswordResetTokenAsync(user);
					var resetPasswordLink = Url.Action("ResetPassword", "Account", new {Email=forgetPasswordViewModel.Email,Token=token },Request.Scheme);
					var email = new Email()
					{
						Subject = "Reset your password",
						To = forgetPasswordViewModel.Email,
						Body = resetPasswordLink
                    };
					EmailSettings.SendEmail(email);
					return RedirectToAction(nameof(CheckYourInbox));
				}
				else
				{
					ModelState.AddModelError(string.Empty, "Email is not existed");
				}
			}
			return View(forgetPasswordViewModel);
		}
		public IActionResult CheckYourInbox()
		{
			return View();
		}
        #endregion

        #region Reset Password
		public IActionResult ResetPassword(string Email,string Token ) 
		{
			TempData["Email"] = Email;
			TempData["Token"]=Token;
			return View();		
		}
		[HttpPost]
	    public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
		{
			if (ModelState.IsValid)
			{
				string Email= TempData["Email"]as string;
                string Token = TempData["Token"] as string;
				var user=await _userManager.FindByEmailAsync(Email);
                var result = await _userManager.ResetPasswordAsync(user,Token,resetPasswordViewModel.NewPassword);
				if(result.Succeeded)
				{
					return RedirectToAction(nameof(Login));
				}
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(string.Empty, error.Description);
				}
			}
			return View(resetPasswordViewModel);
		}
        #endregion


    }
}
