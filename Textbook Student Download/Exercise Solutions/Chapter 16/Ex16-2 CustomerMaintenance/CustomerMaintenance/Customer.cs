using System;

namespace CustomerMaintenance
{
    /// <summary>
    /// Customer class
    /// </summary>
    public class Customer
	{
		private string firstName;
		private string lastName;
		private string email;

        /// <summary>
        /// Creates a Customer object with default values.
        /// </summary>
        public Customer()
		{
		}

        /// <summary>
        /// Creates a Customer object with the specified values.
        /// </summary>
        /// <param name="firstName">The first name to be stored in the object.</param>
        /// <param name="lastName">The last name to be stored in the object.</param>
        /// <param name="email">The email address to be stored in the object.</param>
        public Customer(string firstName, string lastName, string email)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.email = email;
		}


        /// <summary>
        /// Gets or sets the customer's first name.
        /// </summary>
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

        /// <summary>
        /// Gets or sets the customer's last name.
        /// </summary>
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

        /// <summary>
        /// Gets or sets the customer's email address.
        /// </summary>
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

        /// <summary>
        /// Concatenates the first name, last name, and email address for display.
        /// </summary>
        /// <returns>The formatted string.</returns>
        public string GetDisplayText() =>
			 firstName + " " + lastName + ", " + email;
	}
}
