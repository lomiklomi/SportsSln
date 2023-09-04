using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
	public class CustomerController : Controller
	{
		private ICustomerRepository repository;
		private Cart cart;
		public CustomerController(ICustomerRepository repoService, Cart cartService)
		{
			repository = repoService;
			cart = cartService;
		}
		public ViewResult Checkout() => View(new Customer());

		[HttpPost]
		public IActionResult Checkout(Customer customer)
		{
			if (cart.Lines.Count() == 0)
			{
				ModelState.AddModelError("", "Извините, ваша корзина пуста!");
			}
			if (ModelState.IsValid)
			{
				customer.Lines = cart.Lines.ToArray();
				repository.SaveCustomer(customer);
				cart.Clear();
				return RedirectToPage("/Completed", new { customerId = customer.CustomerID });
			}
			else
			{
				return View();
			}
		}
	}
}