using System;

namespace CustomerMaintenance
{
    public class WholesaleCustomer : Customer
	{

        private string company;

		public WholesaleCustomer()
		{
		}

        public WholesaleCustomer(string lastName, string firstName, 
            string email, string company) : base(lastName, firstName, email)
        {
            this.company = company;
        }

        public string Company
        {
            get
            {
                return this.company;
            }
            set
            {
                this.company = value;
            }
        }

        public override string GetDisplayText()
        {
            return base.GetDisplayText() + " (" + this.company + ")";
        }

	}
}
