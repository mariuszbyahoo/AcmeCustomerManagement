using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAdress { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void ValidateEmail()
        {
            //if the user requested a receipt
            //get the customer data
            //Ensure a valid email adress was provided
            //If not,
            // request an email from the user.
        }
    }
}
