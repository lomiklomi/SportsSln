using System.ComponentModel.DataAnnotations;
namespace SportsStore.Models.ViewModels
{
	public class LoginModel
	{
		[Required(ErrorMessage = "Поле \"Имя\" является обязательным для заполнения.")]
		public string? Name { get; set; }
		[Required(ErrorMessage = "Поле для ввода пароля является обязательным.")]
		public string? Password { get; set; }
		public string ReturnUrl { get; set; } = "/";
	}
}