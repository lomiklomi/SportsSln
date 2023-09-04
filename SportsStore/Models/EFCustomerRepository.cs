using Microsoft.EntityFrameworkCore;
namespace SportsStore.Models
{
	public class EFCustomerRepository : ICustomerRepository
	{
		private StoreDbContext context;
		public EFCustomerRepository(StoreDbContext ctx)
		{
			context = ctx;
		}
		public IQueryable<Customer> Customers => context.Customers
			.Include(o => o.Lines)
			.ThenInclude(l => l.Product);

		public void SaveCustomer(Customer customer)
		{
			context.AttachRange(customer.Lines.Select(l => l.Product));
			if (customer.CustomerID == 0)
			{
				context.Customers.Add(customer);
			}
			context.SaveChanges();
		}
		public void CreateCustomer(Customer p)
		{
			context.Add(p);
			context.SaveChanges();
		}
		public void DeleteCustomer(Customer p)
		{
			context.Remove(p);
			context.SaveChanges();
		}
	}
}