using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore.Models
{
	public class Customer
	{
		public long? CustomerID { get; set; }

		[Required(ErrorMessage = "����������, ������� �������� ��������")]
		public string Name { get; set; } = String.Empty;

		[Required(ErrorMessage = "����������, ������� ��������")]
		public string Password { get; set; } = String.Empty;
		
		[Required(ErrorMessage = "����������, ������� ��������")]
		public string Login { get; set; } = String.Empty;

		[Required]
		public Boolean Status { get; set; }

		[Required(ErrorMessage = "����������, ������� ������")]
		public decimal Country { get; set; }

		[Required(ErrorMessage = "����������, ������� ������ ��� �������")]
		public decimal State { get; set; }

		[Required(ErrorMessage = "����������, ������� �����")]
		public decimal City { get; set; }

		[Required(ErrorMessage = "����������, ������� �������")]
		public decimal Mobile { get; set; }

		[Required(ErrorMessage = "����������, ������� ����������� �����")]
		public decimal Email { get; set; }

		public DateTime RegisterDate { get; set; }

		[BindNever]
		public ICollection<CartLine> Lines { get; set; } = new List<CartLine>();
	}
}