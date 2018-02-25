using CustomerService.Classes;

using CustomerService.Forms.AddOnForm;
using CustomerService.Forms.Contacts;
using CustomerService.Forms.County;
using CustomerService.Forms.Implementation;
using CustomerService.Forms.ProgramTypes;
using CustomerService.Forms.Revenue;
using CustomerService.Model;
using CustomerService.Reports;
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace CustomerService
{
    public partial class frmCustomerService : Form
    {

        CustomersContext CustomerDb = new CustomersContext();
        public int CustomerId { get; set; }
        public int ImplentationiD { get; set; }
        public int ContactId { get; set; }
        public int Revenueid { get; set; }
        public int ProgramTypeId { get; set; }
        public bool IsNewCustomer { get; set; }
        public bool isAdmin { get; set; }
        public int AddOnId { get; set; }
        public frmCustomerService()
        {
            InitializeComponent();
        }

        private void frmCustomerService_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDbDataSet8.CustomerContacts' table. You can move, or remove it, as needed.
            this.customerContactsTableAdapter1.Fill(this.customerDbDataSet8.CustomerContacts);
            // TODO: This line of code loads data into the 'customerDbDataSet7.revenue' table. You can move, or remove it, as needed.
            this.revenueTableAdapter.Fill(this.customerDbDataSet7.revenue);
            // TODO: This line of code loads data into the 'customerDbDataSet6.AddOns' table. You can move, or remove it, as needed.
            this.addOnsTableAdapter1.Fill(this.customerDbDataSet6.AddOns);
            // TODO: This line of code loads data into the 'customerDbDataSet5.ProgamTypes' table. You can move, or remove it, as needed.
            this.progamTypesTableAdapter.Fill(this.customerDbDataSet5.ProgamTypes);


            if (isAdmin)

            { RadPageViewPage pageToRemove = this.radPageView2.Pages["radPageViewPage4"];
                this.radPageView2.Pages.Remove(pageToRemove);
            }

            this.rgAddons.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            


            this.customerContactsTableAdapter.Fill(this.customerDbDataSet.CustomerContacts);
            BindCustomers();
            IsNewCustomer = false;
            rgCustomers.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

        }

        private void BindCustomers()
        {
            rgCustomers.DataSource = CustomerDb.GetALLCustomers();
            rgCustomers.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
             

        }

        private void rgCustomers_SelectionChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            if (rgCustomers.CurrentRow.Cells[0].Value != null)
            {
                CustomerId = (int)rgCustomers.CurrentRow.Cells[0].Value;

                
                BindCustomerDetail(CustomerId);
                BindCountiesForCustomer();
                BindImplentationsForCustomer(CustomerId);
                rgCustomers.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
                BindAddOns(CustomerId);
                BindContacts(CustomerId);

            }

        }

        public void BindAddOns(int id)
        {

            rgAddons.DataSource = CustomerDb.GetAllAddonsByCustomerId(id);
            rgAddons.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

        }
        public void BindRevenue(int id)
        {
            grdRevenue.DataSource = CustomerDb.GetAlLRevenuByCustomerId(id);
            grdRevenue.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

        }
        public void BindContacts(int id)
        {
            rgContacts.DataSource = CustomerDb.GetAlLContactsByCustomerId(id);
            rgContacts.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;


        }
        private void BindCustomerDetail(int Id)
        {
            Customer q = CustomerDb.GetCustomerById(Id);
            if (q != null)
            {
                txtCustomerName.Text = q.CustomerName;
                txtEmail.Text = q.EmailAddress;
                txtAddress1.Text = q.Address1;
                txtAddress2.Text = q.Address2;
                txtCounty.Text = q.County;
                txtMobile.Text = q.MobileNumber;
                txtPhone.Text = q.PhoneNumber;
              
                rdDateJoined.Value = q.CustomerJoined.HasValue ? (DateTime)q.CustomerJoined : DateTime.MinValue;
              
                txtState.Text = q.State;
                
               
            }

        }
      

        private void btnAddContacts_Click(object sender, EventArgs e)
        {
            frmContact _frmContacts = new frmContact();
            _frmContacts.StartPosition = FormStartPosition.CenterScreen;
            _frmContacts.CustomerId = CustomerId;
            _frmContacts.IsEditMode = false;
            _frmContacts.ShowDialog();
            BindContacts(CustomerId);


        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {

            frmContact _frmContacts = new frmContact();
            _frmContacts.StartPosition = FormStartPosition.CenterScreen;
            _frmContacts.CustomerId = CustomerId;
            _frmContacts.ContactId = ContactId;
            _frmContacts.IsEditMode = true;
            _frmContacts.ShowDialog();
            BindContacts(CustomerId);
        }

        private void rgContacts_SelectionChanged(object sender, EventArgs e)
        {
            if (rgContacts.SelectedRows.Count > 0)
            {
                if (rgContacts.CurrentRow.Cells[0].Value != null)
                {
                    ContactId = (int)rgContacts.CurrentRow.Cells[0].Value;

                }
            }
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            frmImplementation _implementation = new frmImplementation();
            _implementation.StartPosition = FormStartPosition.CenterScreen;

            _implementation.ShowDialog();

        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            frmCounty _frmCounty = new frmCounty();
            _frmCounty.CustomerId = CustomerId;
            _frmCounty.ShowDialog();
            BindCountiesForCustomer();

        }

        private void BindImplentationsForCustomer(int customerid)

        {

            grdImplentations.DataSource = CustomerDb.GetAllImpentationsByCustomerId(customerid);
        }
        public void BindCountiesForCustomer()
        {

            grdCounties.DataSource = CustomerDb.GetALLCustomerCountiesForList(this.CustomerId);

        }

        private void radStatusStrip1_StatusBarClick(object sender, Telerik.WinControls.UI.RadStatusBarClickEventArgs args)
        {

        }

        private void rgCustomers_SelectionChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAddImplentation_Click(object sender, EventArgs e)
        {
            frmImplementation _frmImp = new frmImplementation();
            _frmImp.CustomerId = this.CustomerId;
            _frmImp.IsEdit = false;
            _frmImp.ShowDialog();
            BindImplentationsForCustomer(CustomerId);
        }

        private void grdImplentations_SelectionChanged(object sender, EventArgs e)
        {
            if (grdImplentations.SelectedRows.Count > 0)
            {

                if (grdImplentations.CurrentRow.Cells[0].Value != null)
                {
                    if (grdImplentations.RowCount > 0)
                        this.ImplentationiD = (int)grdImplentations.CurrentRow.Cells[0].Value;

                }
            }
        }

        private void btnEditImplentation_Click(object sender, EventArgs e)
        {
            frmImplementation _frmImp = new frmImplementation();
            _frmImp.CustomerId = this.CustomerId;
            _frmImp.RecordId = this.ImplentationiD;
            _frmImp.IsEdit = true;
            _frmImp.ShowDialog();
            BindImplentationsForCustomer(CustomerId);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            frmRevenue _frmRevenue = new frmRevenue();
            _frmRevenue.CustomerId = CustomerId;
            _frmRevenue.RecordId = Revenueid;
            _frmRevenue.IsEdit = true; 
            _frmRevenue.ShowDialog();
            BindRevenue(CustomerId);
        }

        private void btnAddRevenue_Click(object sender, EventArgs e)
        {
            frmRevenue _frmRevenue = new frmRevenue();
            _frmRevenue.CustomerId = CustomerId;
            _frmRevenue.RecordId = Revenueid;
            _frmRevenue.IsEdit = false;
            _frmRevenue.ShowDialog();

            BindRevenue(CustomerId);

        }

        private void grdRevenue_SelectionChanged(object sender, EventArgs e)
        {
            if (grdRevenue.SelectedRows.Count > 0)
            {

                if (grdRevenue.CurrentRow.Cells[0].Value != null)
                {
                    this.Revenueid = (int)grdRevenue.CurrentRow.Cells[0].Value;

                }

            }

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            IsNewCustomer = true;

           
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);

                  foreach (Control control2 in controls)
                    if (control2 is RichTextBox)
                    (control2 as RichTextBox).Clear();

                txtNotes.Text = "";
               
            };

            func(Controls);
         
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            Customer _cust = new Customer();
            if (!IsNewCustomer)
                _cust = CustomerDb.GetCustomerById(CustomerId);
            _cust.Address1 = txtAddress1.Text;
            _cust.Address2 = txtAddress2.Text;
            _cust.County = txtCounty.Text;
            _cust.PhoneNumber = txtPhone.Text;
            _cust.EmailAddress = txtEmail.Text;
            _cust.CustomerJoined = rdDateJoined.Value;
            _cust.Notes = txtNotes.Text;
            _cust.State = txtState.Text;
            _cust.isActive = true;
            

            if (IsNewCustomer)
            {
                CustomerDb.AddToCustomer(_cust);
                CustomerDb.SaveChanges();
                MessageBox.Show("Customer Created", "Customer has been created for the information entered", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }else
            {
                 CustomerDb.SaveCustomer(_cust);
                CustomerDb.SaveChanges();
                MessageBox.Show("Customer Updated", "Customer has been updates for the information entered", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
             

            ReportPrintTool printTool = new ReportPrintTool(new ReportRevenue());

              // Invoke the Ribbon Print Preview form modally  
            // with the specified look and feel settings.  
            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
  
        }

        private void btnAddAddon_Click(object sender, EventArgs e)
        {
            frmAddon _frmAddOn = new  frmAddon();
            _frmAddOn.CustomerId = CustomerId;
            
            _frmAddOn.IsEditMode = false;

            _frmAddOn.ShowDialog();
            BindAddOns(CustomerId);
        }

        private void btnEditAddon_Click(object sender, EventArgs e)
        {

            frmAddon _frmAddOn = new frmAddon();
            _frmAddOn.CustomerId = CustomerId;
            _frmAddOn.AddOnId = AddOnId;
            _frmAddOn.IsEditMode = true;

            _frmAddOn.ShowDialog();
            BindAddOns(CustomerId);
        }

        private void btnEditProgramTypes_Click(object sender, EventArgs e)
        {

            frmProgramTypes _frmPrograType = new frmProgramTypes();
            _frmPrograType.ProgramTypeId = ProgramTypeId;
            _frmPrograType.CustomerId = CustomerId;
            _frmPrograType.IsEditMode = true;
            _frmPrograType.ShowDialog();
        }

        private void rgProgramTypes_SelectionChanged(object sender, EventArgs e)
        {
          

                if (rgProgramTypes.CurrentRow.Cells[0].Value != null)
                {
                    this.ProgramTypeId = (int)rgProgramTypes.CurrentRow.Cells[0].Value;

                }
           
            
        }

        private void rgAddons_SelectionChanged(object sender, EventArgs e)
        {
            if (rgAddons.SelectedRows.Count > 0)
            {
                if (rgAddons.CurrentRow.Cells[0].Value != null)
                {
                    this.AddOnId = (int)rgAddons.CurrentRow.Cells[0].Value;

                }
            }
        }

        private void btnDeleteAddon_Click(object sender, EventArgs e)
        {
            AddOn _DeleteAddOn = new AddOn();
            _DeleteAddOn = CustomerDb.GetAddOnById(AddOnId);
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to Delete Addon ", "Delete Addon", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                CustomerDb.DeleteAddon(_DeleteAddOn);
                BindAddOns(CustomerId);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            CustomerContact _DeleteContact = new CustomerContact();
            _DeleteContact = CustomerDb.GetCustomerContactById(ContactId);
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to Delete Contact ", "Delete Contact", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                CustomerDb.DeleteContact(_DeleteContact);
                BindContacts(CustomerId);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnDeleteRevenue_Click(object sender, EventArgs e)
        {
            revenue _deleteRevenue = new revenue();
            _deleteRevenue = CustomerDb.GetRevenueById(Revenueid);
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to Delete Revenue ", "Delete Revenue", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                CustomerDb.DeleteRevenue(_deleteRevenue);
                BindRevenue(CustomerId);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnDeleteImplentation_Click(object sender, EventArgs e)
        {
            Implentat _deleteImplentat = new Implentat();
            _deleteImplentat = CustomerDb.GetImplentationById(ImplentationiD);
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to Delete Implentation ", "Delete Implentation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                CustomerDb.DeleteImplmentation(_deleteImplentat);
                BindImplentationsForCustomer(CustomerId);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void radButton8_Click(object sender, EventArgs e)
        {

            Implentat _deleteImplentat = new Implentat();
            _deleteImplentat = CustomerDb.GetImplentationById(ImplentationiD);
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to Delete Implentation ", "Delete Implentation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                CustomerDb.DeleteImplmentation(_deleteImplentat);
                BindImplentationsForCustomer(CustomerId);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnAddProgramTypes_Click(object sender, EventArgs e)
        {
            frmProgramTypes _frmPrograType = new frmProgramTypes();
            _frmPrograType.ProgramTypeId = ProgramTypeId;
            _frmPrograType.CustomerId = CustomerId;
            _frmPrograType.IsEditMode = false;
            _frmPrograType.ShowDialog();
        }
    }
}
