using ACM.BL;
using Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcmeCustomerManagement
{
    public partial class OrderWin : Form
    {

        private void button1_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        private void PlaceOrder()
        {
            var customer = new Customer();
            // Populate the customer instance

            var order = new Order();
            // Populate the order instance

            var payment = new Payment();
            // Populate the payment info from the UI

            var orderController = new OrderController();

            orderController.PlaceOrder(customer, order, payment, 
                                                allowSplitOrders : false, 
                                                emailReceipt: true);
            // Above we see a Named method's arguments
        }

        public OrderWin()
        {
            InitializeComponent();
        }
    }
}
