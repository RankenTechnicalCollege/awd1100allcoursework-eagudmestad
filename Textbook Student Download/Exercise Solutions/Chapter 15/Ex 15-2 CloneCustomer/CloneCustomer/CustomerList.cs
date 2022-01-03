using System;
using System.Collections.Generic;
using System.Text;

namespace CloneCustomer
{
    public class CustomerList : IEnumerable<Customer>
	{
        private List<Customer> customers = new List<Customer>();

		public int Count => customers.Count;

		public Customer this[int i] => customers[i];

		public void Add(Customer customer) => customers.Add(customer);

        public IEnumerator<Customer> GetEnumerator()
        {
            foreach (Customer c in customers)
            {
                yield return c;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
