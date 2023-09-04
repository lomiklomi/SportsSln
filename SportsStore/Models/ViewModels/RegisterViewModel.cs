using System.ComponentModel.DataAnnotations;
namespace SportsStore.Models.ViewModels
{
	public class RegisterViewModel
	{
		public IEnumerable<Customer> Customers { get; set; }
			= Enumerable.Empty<Customer>();
	}
}