using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerMaintenance
{
    public class CustomerList
	{
		private List<Customer> customers;

		public CustomerList()
		{
            customers = new List<Customer>();
		}

		public int Count => customers.Count;

		public Customer this[int i]
		{
			get
			{
				return customers[i];
			}
			set
			{
				customers[i] = value;
			}
		}

		public void Fill() => customers = CustomerDB.GetCustomers();

		public void Save() => CustomerDB.SaveCustomers(customers);

		public void Add(Customer customer)
		{
			customers.Add(customer);
		}

		public void Remove(Customer customer)
		{
			customers.Remove(customer);
		}
	}
}
