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
    public partial class UserControl2 : UserControl
    {
        Models.MyContext context = new Models.MyContext();
        public UserControl2()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                CustomerDetail nc = new CustomerDetail();
                nc.CustomerId = f2.txtId.Text;
                nc.CustomerName = f2.txtName.Text;
                nc.Segment = f2.cbSegment.Text;
                nc.PostalCode = int.Parse(f2.cbPostal.Text);

                context.CustomerDetails.Add(nc);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                FilterCustomer();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan törölni szeretné?\r\n A vevővel vegyütt a rendelései is törlődni fognak!", "Vevő törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selectedCustomer = (CustomerDetail)lbCustomers.SelectedItem;
                var customerToDelete = (from x in context.CustomerDetails
                                        where x.CustomerId == selectedCustomer.CustomerId
                                        select x).FirstOrDefault();

                context.CustomerDetails.Remove(customerToDelete);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                FilterCustomer();
            }

        }
    }
}
