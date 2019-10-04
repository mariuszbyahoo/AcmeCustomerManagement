using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum PaymentType
        {
            CreditCard = 1,
            PayPal = 2,
        }
    public class Payment
    {
        public int PaymentType { get; set; }

        public void ProcessPayment()
        {
            PaymentType paymentTypeOption;
            
            // First try to check is the inputted argument of PaymentType valid
            if (!Enum.TryParse(this.PaymentType.ToString(), out paymentTypeOption))
                throw new InvalidEnumArgumentException("Payment Type", (int)this.PaymentType, typeof(PaymentType));

            switch (paymentTypeOption)
            {
                case ACM.BL.PaymentType.CreditCard:
                    // Process credit card
                    break;

                case ACM.BL.PaymentType.PayPal:
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
