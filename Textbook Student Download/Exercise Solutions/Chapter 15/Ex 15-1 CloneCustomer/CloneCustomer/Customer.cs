using System;

namespace CloneCustomer
{
    public class Customer : ICloneable
	{
		private string firstName;
		private string lastName;
		private string email;

		public Customer()
		{
		}

		public Customer(string firstName, string lastName, string email)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Email = email;
		}

		public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
				firstName = value;
			}
		}

		public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
				lastName = value;
			}
		}

		public string Email
		{
			get
			{
				return email;
			}
			set
			{
				email = value;
			}
		}

		public string GetDisplayText() =>
			 firstName + " " + lastName + ", " + email;

        public object Clone() =>
             new Customer(this.FirstName, this.LastName, this.Email);
    }
}
