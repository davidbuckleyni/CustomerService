using CustomerService.Classes;
using CustomerService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomerService.Forms.County
{
    public partial class frmCounty : Form
    {

        CustomersContext _db = new CustomersContext();
        public int CustomerId { get; set; }
        public int databaseId { get; set; }
        public frmCounty()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void frmCounty_Load(object sender, EventArgs e)
        {
            cboCountys.DisplayMember = "Description";
            cboCountys.ValueMember = "Code";
 
       

           // cboCountys.DataSource = _db.GetALLCustomerCounties(databaseId);


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerCounty _newRecord = new CustomerCounty();

            _newRecord.CustomerId = this.CustomerId;
            _newRecord.CountyCode = (int) cboCountys.SelectedValue;
            _newRecord.CountyDescription = cboCountys.Text;
            _db.AddToCounties(_newRecord);
            _db.SaveChanges();
            this.Close();





        }
    }
}
