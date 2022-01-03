using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerMaintenance
{
    public class Customer
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
                if (value.Length > 30)
                {
                    throw new ArgumentException(
                        "Maximum length of first name is 30 characters.");
                }
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
                if (value.Length > 30)
                {
                    throw new ArgumentException(
                        "Maximum length of last name is 30 characters.");
                }
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
                if (value.Length > 30)
                {
                    throw new ArgumentException(
                        "Maximum length of email address is 30 characters.");
                }
                email = value;
			}
		}

		public string GetDisplayText() => firstName + " " + lastName + ", " + email;
	}
}
