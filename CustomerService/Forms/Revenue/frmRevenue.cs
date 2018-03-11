using CustomerService.Classes;
using CustomerService.Model;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomerService.Forms.Revenue
{
    public partial class frmRevenue : Form
    {
        public frmRevenue()
        {
            InitializeComponent();
        }
        CustomersContext _db = new CustomersContext();
     
        public int CustomerId { get; set; }
        public int RecordId { get; set; }
        public bool IsEdit { get; set; }
        public int databaseId { get; set; }
        private void frmRevenue_Load(object sender, EventArgs e)
        {

            if (IsEdit)
            {
                revenue _revenue = new revenue();
                _revenue = _db.GetRevenueById(this.RecordId,databaseId);
                txtUsers.Text = _revenue.Users.ToString();
                txtRevenue.Text = _revenue.RevenueAmount.ToString();
                cboYear.SelectedText = _revenue.Year.ToString();
                if (_revenue.PriceFixedUntil!=null)
                rdPriceFixedUnitl.Value = (DateTime)_revenue.PriceFixedUntil;
            }




       cboYear.DataSource = Enumerable.Range(1950, DateTime.Today.Year).ToList();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            revenue _revenue = new revenue();
            if (IsEdit == true)
            {
                _revenue = _db.GetRevenueById(this.RecordId,databaseId);
            }
            _revenue.Users = Convert.ToInt32(txtUsers.Text);
            _revenue.PriceFixedUntil = rdPriceFixedUnitl.Value;
            _revenue.RevenueAmount =Convert.ToDecimal(txtRevenue.Text);
            _revenue.customerid = CustomerId;
            _revenue.Year =Convert.ToInt16(cboYear.Text);
            _revenue.isActive = true;
            _revenue.CreatedDate = DateTime.Now;
            _revenue.databaseID = databaseId;
            if (IsEdit == false)
            {
                _db.AddToRevenue(_revenue);
                _db.SaveChanges();
                MessageBox.Show("Revenue Saved", "Revenue has been Created ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                _db.SaveRevenue(_revenue);
                _db.SaveChanges();
                MessageBox.Show("Revenue  Saved", "Revenue has been updated ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            this.Close();
        }
    }
}
