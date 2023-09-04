using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace SportsStore.Models
{
	public class Order {
		[BindNever]
		public int OrderID { get; set; }
		[BindNever]
		public ICollection<CartLine> Lines { get; set; } = new List<CartLine>();
		[Required(ErrorMessage = "Пожалуйста введите имя")]
		public string? Name { get; set; }
		[Required(ErrorMessage = "Пожалуйста введите город")]
		public string? City { get; set; }
		[Required(ErrorMessage = "Пожалуйста введите регион")]
		public string? State { get; set; }
		[Required(ErrorMessage = "Пожалуйста введите страну")]
		public string? Country { get; set; }
		public bool GiftWrap { get; set; }

		[BindNever]
		public bool Shipped { get; set; }

		[BindNever]
		public long CustomerID { get; set; }
	}
}