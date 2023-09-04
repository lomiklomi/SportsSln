using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore.Models
{
	public class Customer
	{
		public long? CustomerID { get; set; }

		[Required(ErrorMessage = "Пожалуйста, введите название продукта")]
		public string Name { get; set; } = String.Empty;

		[Required(ErrorMessage = "Пожалуйста, введите описание")]
		public string Password { get; set; } = String.Empty;
		
		[Required(ErrorMessage = "Пожалуйста, введите описание")]
		public string Login { get; set; } = String.Empty;

		[Required]
		public Boolean Status { get; set; }

		[Required(ErrorMessage = "Пожалуйста, введите страну")]
		public decimal Country { get; set; }

		[Required(ErrorMessage = "Пожалуйста, введите регион или область")]
		public decimal State { get; set; }

		[Required(ErrorMessage = "Пожалуйста, введите город")]
		public decimal City { get; set; }

		[Required(ErrorMessage = "Пожалуйста, введите телефон")]
		public decimal Mobile { get; set; }

		[Required(ErrorMessage = "Пожалуйста, введите электронную почту")]
		public decimal Email { get; set; }

		public DateTime RegisterDate { get; set; }

		[BindNever]
		public ICollection<CartLine> Lines { get; set; } = new List<CartLine>();
	}
}