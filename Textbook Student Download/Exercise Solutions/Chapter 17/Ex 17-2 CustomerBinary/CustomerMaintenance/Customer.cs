using System;

namespace CustomerMaintenance
{
    /// <summary>
    /// Customer class
    /// </summary>
    public class Customer
	{
		public Customer()
		{
		}

		public Customer(string firstName, string lastName, string email)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Email = email;
		}

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public string GetDisplayText() =>
			FirstName + " " + LastName + ", " + Email;
	}
}
