using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Common;

namespace ACM.BLTests
{
    [TestClass()]
    public class OrderControllerTests
    {
        [TestMethod()]
        public void PlaceOrderTest()
        {
            //--Arrange
            var orderController = new OrderController();
            var customer = new Customer() { EmailAdress = "mariusz.budzisz@yahoo.com" };
            var order = new Order();
            var payment = new Payment() { PaymentType = 1 };

            //--Act
            OperationResult op = orderController.PlaceOrder(customer, order, payment,
                allowSplitOrders: true, emailReceipt: true);

            //--Assert
            Assert.AreEqual(true, op.Success);
            Assert.AreEqual(0, op.MessageList.Count);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PlaceOrderTestNullCustomer()
        {
            //--Arrange
            var orderController = new OrderController();
            Customer customer = null;
            var order = new Order();
            var payment = new Payment() { PaymentType = 1 };

            //--Act
            OperationResult op = orderController.PlaceOrder(customer, order, payment,
                allowSplitOrders: true, emailReceipt: true);

            //--Assert

        }

        [TestMethod()]
        public void PlaceOrderTestInvalidEmail()
        {
            //--Arrange
            var orderController = new OrderController();
            var customer = new Customer() { EmailAdress = "" };
            var order = new Order();
            var payment = new Payment() { PaymentType = 1 };

            //--Act
            OperationResult op = orderController.PlaceOrder(customer, order, payment,
                allowSplitOrders: true, emailReceipt: true);

            //--Assert
            Assert.AreEqual(true, op.Success);
            Assert.AreEqual(1, op.MessageList.Count);
            Assert.AreEqual("Email adress is null", op.MessageList[0]);
        }
    }
}