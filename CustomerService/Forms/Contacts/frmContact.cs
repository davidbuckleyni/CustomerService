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

namespace CustomerService.Forms.Contacts
{
    public partial class frmContact : Form
    {
        CustomersContext _db = new CustomersContext();
        public int CustomerId { get; set; }
        public int ContactId { get; set; }
        public bool IsEditMode { get; set; }
        public frmContact()
        {
            InitializeComponent();
        }

        private void frmContact_Load(object sender, EventArgs e)
        {
            cboPrimaryContact.DisplayMember = "Description";
            cboPrimaryContact.ValueMember = "Code";
            cboPrimaryContact.DataSource = _db.GetStandardLookupByGroup(4);
            if (IsEditMode == true)


            {
                CustomerContact q = _db.GetCustomerContactById(ContactId);
                txtPhone.Text = q.phone.Trim();
                txtEmail.Text = q.email.Trim();
                txtName.Text = q.Name.Trim();
                isPrimary.Value = (bool)q.isPrimayContact;
                if(q.PoistionId != null)
                cboPrimaryContact.SelectedValue = q.PoistionId;
            }

          

      



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerContact CustomerContactRecord = new CustomerContact();
            if (IsEditMode)
            {
                CustomerContactRecord = _db.GetCustomerContactById(ContactId);
            }
            CustomerContactRecord.phone = txtPhone.Text;
            CustomerContactRecord.email = txtEmail.Text.Trim();
            CustomerContactRecord.Name = txtName.Text;
            CustomerContactRecord.isPrimayContact = isPrimary.Value;
            CustomerContactRecord.isActive = true;
            CustomerContactRecord.CustomerId = CustomerId;
            CustomerContactRecord.PoistionId = (int) cboPrimaryContact.SelectedValue;
            if (IsEditMode == true)
            {

                _db.SaveCustomerContact(CustomerContactRecord);
                _db.SaveChanges();

                MessageBox.Show("Contact Saved", "Contact has been Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                _db.AddToContact(CustomerContactRecord);
                _db.SaveCustomerContact(CustomerContactRecord);
                MessageBox.Show("Contact Saved", "Contact has been Created", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            this.Close();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
