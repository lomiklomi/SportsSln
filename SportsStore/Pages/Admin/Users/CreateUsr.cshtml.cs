using Advanced.Pages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Pages
{
	public class CreateModel : AdminPageModel
	{
		public UserManager<IdentityUser> UserManager;
		public CreateModel(UserManager<IdentityUser> usrManager)
		{
			UserManager = usrManager;
		}
		[BindProperty]
		public string UserName { get; set; } = string.Empty;
		[BindProperty]
		[EmailAddress]
		public string Email { get; set; } = string.Empty;
		[BindProperty]
		public string Password { get; set; } = string.Empty;
		public async Task<IActionResult> OnPostAsync()
		{
			if (ModelState.IsValid)
			{
				IdentityUser user =
				new IdentityUser { UserName = UserName, Email = Email };
				IdentityResult result =
				await UserManager.CreateAsync(user, Password);
				if (result.Succeeded)
				{
					return RedirectToPage("List");
				}
				foreach (IdentityError err in result.Errors)
				{
					ModelState.AddModelError("", err.Description);
				}
			}
			return Page();
		}
	}
}
