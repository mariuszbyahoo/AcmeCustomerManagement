using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Payment
    {
        public int PaymentType { get; set; }

        public void ProcessPayment()
        {
            switch (this.PaymentType)
            {
                case 1:
                    // Process credit card
                    break;

                case 2:
                    // Process PayPal
                    break;

                default:
                    throw new ArgumentException();
            }

            //Open a connection
            //Set stored procedure parameters with the payment data.
            //Call the save stored procedure

        }
    }
}
