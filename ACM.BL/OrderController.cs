using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderController
    {
        private CustomerRepository customerRepository { get; set; }
        private OrderRepository orderRepository { get; set; }
        private InventoryRepository inventoryRepository { get; set; }
        private EmailLibrary emailLibrary { get; set; }

        public OrderController()
        {
            customerRepository = new CustomerRepository();
            orderRepository = new OrderRepository();
            inventoryRepository = new InventoryRepository();
            emailLibrary = new EmailLibrary();

        }

        public OperationResult PlaceOrder(Customer customer, 
                                Order order, 
                                Payment payment,
                                bool allowSplitOrders, 
                                bool emailReceipt)
        {
            //Validating parameters:
            if (customer == null) throw new ArgumentNullException("Customer instance is null");
            if (order == null) throw new ArgumentNullException("Order instance is null");
            if (payment == null) throw new ArgumentNullException("Payment instance is null");
            // The rest of parameters are not reference values, but structs, so they 
            // may be only bool. There is no need to validate them.
            var op = new OperationResult();

            // Processing the method's logic:
            customerRepository.Add(customer);

            orderRepository.Add(order);

            inventoryRepository.OrderItems(order, allowSplitOrders);

            payment.ProcessPayment();

            if (emailReceipt)
            {
                var result = customer.ValidateEmail();
                if (result.Success)
                {
                    customerRepository.Update();

                    emailLibrary.SendEmail(customer.EmailAdress,
                        "Here is your receipt");
                }
                else
                {
                    // log the error messages

                    // returning the result's message.
                    if (result.MessageList.Any())
                    {
                        op.AddMessage(result.MessageList[0]);
                    }
                }
            }

            return op;
        }
    }
}
