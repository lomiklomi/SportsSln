namespace SportsStore.Models
{
	public interface ICustomerRepository
	{
		IQueryable<Customer> Customers { get; }
		void SaveCustomer(Customer customer);
		void CreateCustomer(Customer customer);
		void DeleteCustomer(Customer customer);

	}
}