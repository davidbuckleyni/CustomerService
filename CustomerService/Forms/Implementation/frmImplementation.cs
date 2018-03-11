using CustomerService;
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

namespace CustomerService.Forms.Implementation
{
    public partial class frmImplementation : Form
    {
        CustomersContext _db = new CustomersContext();
        public bool IsEdit { get; set; }
        public int CustomerId { get; set; }
        public int RecordId { get; set; }
        public int databaseId { get; set; }
        public frmImplementation()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void frmImplementation_Load(object sender, EventArgs e)
        {
            radMaskedEditBox1.MaskType = Telerik.WinControls.UI.MaskType.Numeric;


           

            cboDataMIgrationLead.DisplayMember = "Description";
            cboDataMIgrationLead.ValueMember = "Code";
            cboDataMIgrationLead.DataSource = _db.GetStandardLookupByGroup(Costants.DataMigrationList);


 
            if (this.IsEdit)
            {
                Implentat _newImp = new Implentat();

                _newImp = _db.GetImplentationById(RecordId,databaseId);
                txtFee.Text = _newImp.ImplentationFee.ToString();
                chkIsLive.Checked = _newImp.Live ?? false;
                chkIsPaid.Checked = _newImp.Paid ?? false;
                txtOldEhr.Text = _newImp.OldEhr.ToString();
              
                cboDataMIgrationLead.SelectedValue = _newImp.DataMigrationLead ?? 0;

                txtProjectManager.Text = _newImp.ProjectManager;
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            Implentat _imp = new Implentat();
            if (this.IsEdit)
                _imp = _db.GetImplentationById(RecordId,databaseId);

            _imp.customerId = this.CustomerId;
           
            _imp.ImplentationFee =Convert.ToDecimal(txtFee.Text);

            //   _imp.DataMigrationLead = (int)cboDataMIgrationLead.SelectedValue;
            _imp.ProjectManager = txtProjectManager.Text;   
              _imp.Paid = chkIsPaid.Checked;
            _imp.Live = chkIsLive.Checked;
            _imp.databaseID = databaseId;
            _imp.OldEhr =Int32.Parse(txtOldEhr.Text);
             
            if (this.IsEdit)
            {
                _db.SaveImplmentation(_imp);
                _db.SaveChanges();
                MessageBox.Show("Implentation Saved", "Implentation has been updated ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else
            {
                _db.AddToImplemtnation(_imp);
                _db.SaveChanges();
                MessageBox.Show("Implentation Saved", "Implentation has been Created ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
