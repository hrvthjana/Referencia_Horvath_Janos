using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH2_M29VLR.Models;

namespace ZH2_M29VLR
{
    public partial class UserControl1 : UserControl
    {
        Models.MyContext context = new Models.MyContext();
        public UserControl1()
        {
            InitializeComponent();
            FilterCustomer();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            FilterCustomer();
        }

        private void FilterCustomer()
        {
            var filterCustomer = from x in context.CustomerDetails
                                 where x.CustomerName.StartsWith(txtFilter.Text)
                                 select x;
            lbCustomers.DataSource = filterCustomer.ToList();
            lbCustomers.DisplayMember = "CustomerName";
        }

        private void lbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCustomer = (CustomerDetail)lbCustomers.SelectedItem;
            var ordersToShow = from x in context.OrderCustomers
                               where x.CustomerId == selectedCustomer.CustomerId
                               select x;
            lbOrders.DataSource = ordersToShow.ToList();
            lbOrders.DisplayMember = "OrderId";
        }

        private void lbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = (OrderCustomer)lbOrders.SelectedItem;
            var orderInfo = from x in context.OrderCustomers
                            join op in context.OrderProducts on x.OrderId equals op.OrderId
                            where x.OrderId == selectedOrder.OrderId
                            select new SajatClass
                            {
                                CustomerName = x.Customer.CustomerName,
                                Category = op.Product.Category,
                                SubCategory = op.Product.SubCategory,
                                OrderDate = x.Order.OrderDate,
                                ShipDate = x.Order.ShipDate,
                                shipMode = x.Order.ShipMode,
                                Sales = (double)op.Sales

                            };
            sajatClassBindingSource.DataSource = orderInfo.ToList();

            var total = (from x in context.OrderProducts
                         where x.OrderId == selectedOrder.OrderId
                         select x.Sales).Sum();
            txtTotal.Text = total.ToString();
        }
    }
    public class SajatClass
    {
        public string CustomerName { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public string shipMode { get; set; }
        public double Sales { get; set; }
    }
}
