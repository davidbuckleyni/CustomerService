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
        public int databaseId { get; set; }
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
                _newAddon = _db.GetAddOnById(AddOnId,databaseId);
            }
             _newAddon.PeriscopeCost = Convert.ToDecimal(txtPeriScopeAmount.Text);
            _newAddon.OQAnalyst = chkoqanalyst.Checked;
            _newAddon.RxNT = chkrxnt.Checked;
            _newAddon.Availity = chkavaility.Checked;
            _newAddon.CustomerId = CustomerId;
            _newAddon.PeriscopeStatus =(int) cboPeriscopeStatus.SelectedValue;
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


            cboPeriscopeStatus.DisplayMember = "Description";
            cboPeriscopeStatus.ValueMember = "Code";



            cboPeriscopeStatus.DataSource = _db.GetStandardLookupByGroup(5);


            AddOn _newAddon = new Model.AddOn();
            if (IsEditMode == true)
            {
                _newAddon = _db.GetAddOnById(AddOnId, databaseId);
         
                 txtPeriScopeAmount.Text = _newAddon.PeriscopeCost.ToString();
                chkavaility.Checked = (bool)_newAddon.Availity;
                chkoqanalyst.Checked = (bool)_newAddon.OQAnalyst;
                chkrxnt.Checked = (bool)_newAddon.RxNT;
                cboPeriscopeStatus.SelectedValue = _newAddon.PeriscopeStatus;
                
            }




        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
