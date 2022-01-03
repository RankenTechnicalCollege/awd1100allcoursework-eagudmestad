using System;
using System.Collections.Generic;

namespace CloneCustomer
{
    public class CustomerList
	{
        private List<Customer> customers = new List<Customer>();

		public int Count => customers.Count;

		public Customer this[int i] => customers[i];

		public void Add(Customer customer) => customers.Add(customer);
	}
}
