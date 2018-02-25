using CustomerService.Classes;
using CustomerService.Forms.Search;
using CustomerService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomerService.Forms.AddOnForm
{
    public partial class frmAddon : Form
    {
        public int CustomerId { get; set; }
        public int AddOnId { get; set; }
        public bool IsEditMode { get; set; }
        CustomersContext _db = new CustomersContext();


        public frmAddon()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddOn _newAddon = new Model.AddOn();
            if (IsEditMode == true)
            {
                _newAddon = _db.GetAddOnById(AddOnId);
            }
            _newAddon.Description = txtDescription.Text;
            _newAddon.Amount = Convert.ToDecimal(txtAmount.Text);
            _newAddon.OQAnalyst = chkoqanalyst.Checked;
            _newAddon.RxNT = chkrxnt.Checked;
            _newAddon.Availity = chkavaility.Checked;
            _newAddon.CustomerId = CustomerId;
            _newAddon.Status = txtStatus.Text;
            if (IsEditMode == true)
            {

                _db.SaveAddon(_newAddon);
                _db.SaveChanges();
                MessageBox.Show("Add On Saved", "Addon has been Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _db.AddToAddon(_newAddon);
                _db.SaveChanges();
                MessageBox.Show("Add On Saved", "Addon has been Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();

            

        }

        private void frmAddon_Load(object sender, EventArgs e)
        {
            AddOn _newAddon = new Model.AddOn();
            if (IsEditMode == true)
            {
                _newAddon = _db.GetAddOnById(AddOnId);
         
            txtDescription.Text = _newAddon.Description;
                txtAmount.Text = _newAddon.Amount.ToString();
                chkavaility.Checked = (bool)_newAddon.Availity;
                chkoqanalyst.Checked = (bool)_newAddon.OQAnalyst;
                chkrxnt.Checked = (bool)_newAddon.RxNT;
                txtStatus.Text = _newAddon.Status;
            }




        }



    
}
}
