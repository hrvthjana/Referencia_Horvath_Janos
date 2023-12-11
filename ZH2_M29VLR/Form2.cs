using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_M29VLR
{
    public partial class Form2 : Form
    {
       Models.MyContext context = new Models.MyContext();
       
        public Form2()
        {
            InitializeComponent();
            var getSegment = (from x in context.CustomerDetails
                              select x.Segment).Distinct();
            cbSegment.DataSource = getSegment.ToList();
            var getPostal = (from x in context.CustomerDetails
                              select x.PostalCode).Distinct();
            cbPostal.DataSource = getPostal.ToList();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == true)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


      

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtName,"A mező nem lehet üres!");
            }
        }
        private void txtName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtName, string.Empty);
        }

        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex("^[A-Z]{2}-[0-9]{5}$");
            var getIds = from x in context.CustomerDetails
                         select x.CustomerId;
            if (!r.IsMatch(txtId.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtId,"Az elvárt fomátum: XX-00000!");
            }
            if (getIds.Contains(txtId.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtId,"A megadott ID már szerepel a nyilvántartásban!");
            }
        }

        private void txtId_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtId, string.Empty);
        }

       
    }
}
