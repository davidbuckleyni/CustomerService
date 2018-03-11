using CustomerService.Classes;
using CustomerService.Forms;
using CustomerService.Forms.AddOnForm;
using CustomerService.Forms.Contacts;
using CustomerService.Forms.County;
using CustomerService.Forms.CustomFields;
using CustomerService.Forms.Implementation;
using CustomerService.Forms.Notes;
using CustomerService.Forms.ProgramTypes;
using CustomerService.Forms.Revenue;
using CustomerService.Forms.StandardLookupsEditor;
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
using Telerik.WinControls.Data;
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
        public int NotesId { get; set; }
        public int CutomFieldId { get; set; }
        public int ContractId { get; set; }
        public int DatabaseId { get; set; }
        public frmCustomerService()
        {
            InitializeComponent();
        }

        private void frmCustomerService_Load(object sender, EventArgs e)
        {

            if (isAdmin == false)

            {
                pnlRevenueNotAllowed.Visible = true;
                pnlRevenue.Visible = false;
            }

            this.rgAddons.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;


            BindCustomers();
            IsNewCustomer = false;
            rgCustomers.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            userNameStatus.Text = Properties.Settings.Default.UserName.ToString();

            BindDatabases();

        }

        private void BindCustomers()
        {
            rgCustomers.DataSource = CustomerDb.GetALLCustomers(DatabaseId);
            rgCustomers.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;


        }

        private void rgCustomers_SelectionChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            if (rgCustomers.CurrentRow.Cells[0].Value != null)
            {
                CustomerId = (int)rgCustomers.CurrentRow.Cells[0].Value;
                lbldatabaseName.Text = CustomerDb.GetDatabaseNames(DatabaseId);

                BindCustomerDetail(CustomerId,DatabaseId);
                BindImplentationsForCustomer(CustomerId);
                rgCustomers.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
                BindAddOns(CustomerId);
                BindContacts(CustomerId);
                BindNotes(CustomerId);
                BindCustomFields(CustomerId);
                BindContracts(CustomerId);
                IsNewCustomer = false;

            }

        }
        public void BindNotes(int id)
        {

            rgNotes.DataSource = CustomerDb.GetAlLNotesByCustomerId(id, DatabaseId);
            rgNotes.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

        }


        public void BindAddOns(int id)
        {

            rgAddons.DataSource = CustomerDb.GetAllAddonsByCustomerId(id, DatabaseId);
            rgAddons.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

        }
        public void BindRevenue(int id)
        {
            grdRevenue.DataSource = CustomerDb.GetAlLRevenuByCustomerId(id, DatabaseId);
            grdRevenue.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

        }
        public void BindContacts(int id)
        {
            rgContacts.DataSource = CustomerDb.GetAlLContactsByCustomerId(id, DatabaseId);
            rgContacts.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;


        }
        public void BindContracts(int id)
        {
            rgContracts.DataSource = CustomerDb.GetAllContractsById(id, DatabaseId);
            rgContracts.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;


        }

        public void BindDatabases()
        {
            cboDatabases.ValueMember = "Code";
            cboDatabases.DisplayMember = "Description";
            int UserId = Properties.Settings.Default.UserId;
            cboDatabases.DataSource = CustomerDb.GetAllDatabasesForSearchByUser(UserId);

        }

        public void BindCustomFields(int id)
        {
            rgContacts.DataSource = CustomerDb.GetAllCustomFieldsByCustomer(id, DatabaseId);
            rgContacts.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;


        }

        private void BindCustomerDetail(int Id,int databaseiD)
        {
            Customer q = CustomerDb.GetCustomerById(Id, databaseiD);
            if (q != null)
            {
                bool defaultValue = false;
                txtCustomerName.Text = q.CustomerName;
                txtAddress1.Text = q.Address1;
                txtAddress2.Text = q.Address2;

                txtCounty.Text = q.County;
                txtZip.Text = q.Zip;

                rdDateJoined.Value = q.CustomerJoined.HasValue ? (DateTime)q.CustomerJoined : DateTime.MinValue;

                txtState.Text = q.State;

                chkRiverSide.Checked = (bool)q.RiverSide.HasValue ? (bool)q.RiverSide : false;

                chkSanBernardino.Checked = (bool)q.SanBernardino.HasValue ? (bool)q.SanBernardino : false;

                chkLa.Checked = (bool)q.La.HasValue ? (bool)q.La : false;

                if (q.OrangeCounty != null)
                    chkOrange.Checked = (bool)q.OrangeCounty ? true : false;



            }

        }


        private void btnAddContacts_Click(object sender, EventArgs e)
        {
            frmContact _frmContacts = new frmContact();
            _frmContacts.StartPosition = FormStartPosition.CenterScreen;
            _frmContacts.CustomerId = CustomerId;
            _frmContacts.databaseId = DatabaseId;
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
            _frmContacts.databaseId = DatabaseId;
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

        }

        private void BindImplentationsForCustomer(int customerid)

        {

            grdImplentations.DataSource = CustomerDb.GetAllImpentationsByCustomerId(customerid, DatabaseId);
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
            _frmImp.databaseId = DatabaseId;
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
            _frmImp.databaseId = DatabaseId;
            _frmImp.IsEdit = true;
            _frmImp.ShowDialog();
            BindImplentationsForCustomer(CustomerId);
        }

        private void btnAddRevenue_Click(object sender, EventArgs e)
        {
            frmRevenue _frmRevenue = new frmRevenue();
            _frmRevenue.CustomerId = CustomerId;
            _frmRevenue.RecordId = Revenueid;
            _frmRevenue.IsEdit = false;
            _frmRevenue.databaseId = DatabaseId;
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
            ClearTextBoxes();


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



            };

            func(Controls);

        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            Customer _cust = new Customer();
            if (!IsNewCustomer)
                _cust = CustomerDb.GetCustomerById(CustomerId, DatabaseId);
            _cust.CustomerName = txtCustomerName.Text;
            _cust.Address1 = txtAddress1.Text;
            _cust.Address2 = txtAddress2.Text;
            _cust.County = txtCounty.Text;
            _cust.CustomerJoined = rdDateJoined.Value;
            _cust.SanBernardino = chkSanBernardino.Checked;
            _cust.La = chkLa.Checked;
            _cust.OrangeCounty = chkOrange.Checked;
            _cust.RiverSide = chkRiverSide.Checked;
            _cust.databaseID = DatabaseId;

            if (chkCountyOther.Checked == true)
                _cust.otherCountiesText = txtOtherCounty.Text;
            _cust.Zip = txtZip.Text;
            _cust.State = txtState.Text;
            _cust.isActive = true;
            //concatanate all the counties for easier reporting.
            List<String> counties = new List<string>();


            if (chkLa.Checked)
                counties.Add("La");
            if (chkOrange.Checked)
                counties.Add("Orange County");
            if (chkRiverSide.Checked)
                counties.Add("RiverSide");
            if (chkSanBernardino.Checked)
                counties.Add("La");


            string Countiesjoined = string.Join(",", counties);
            _cust.CountiesForReport = Countiesjoined;
            if (IsNewCustomer)
            {
                CustomerDb.AddToCustomer(_cust);
                CustomerDb.SaveChanges();
                MessageBox.Show("Customer Created", "Customer has been created for the information entered", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                CustomerDb.SaveCustomer(_cust);
                CustomerDb.SaveChanges();
                MessageBox.Show("Customer Updated", "Customer has been updates for the information entered", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            BindCustomers();
        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {


            ReportPrintTool printTool = new ReportPrintTool(new RevenueReport());

            // Invoke the Ribbon Print Preview form modally  
            // with the specified look and feel settings.  
            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);

        }

        private void btnAddAddon_Click(object sender, EventArgs e)
        {
            frmAddon _frmAddOn = new frmAddon();
            _frmAddOn.CustomerId = CustomerId;
            _frmAddOn.databaseId = DatabaseId;
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
            _frmAddOn.databaseId = DatabaseId;
            _frmAddOn.ShowDialog();
            BindAddOns(CustomerId);
        }

        private void btnEditProgramTypes_Click(object sender, EventArgs e)
        {

            frmProgramTypes _frmPrograType = new frmProgramTypes();
            _frmPrograType.ProgramTypeId = ProgramTypeId;
            _frmPrograType.CustomerId = CustomerId;
            _frmPrograType.IsEditMode = true;
            _frmPrograType.databaseId = DatabaseId;
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
            _DeleteAddOn = CustomerDb.GetAddOnById(AddOnId, DatabaseId);
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
            BindAddOns(CustomerId);

        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            CustomerContact _DeleteContact = new CustomerContact();
            _DeleteContact = CustomerDb.GetCustomerContactById(ContactId);
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to Delete Contact ", "Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                CustomerDb.DeleteContact(_DeleteContact);
                BindContacts(CustomerId);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            BindContacts(CustomerId);
        }

        private void btnDeleteRevenue_Click(object sender, EventArgs e)
        {
            revenue _deleteRevenue = new revenue();
            _deleteRevenue = CustomerDb.GetRevenueById(Revenueid, DatabaseId);
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
            BindRevenue(CustomerId);
        }

        private void btnDeleteImplentation_Click(object sender, EventArgs e)
        {
            Implentat _deleteImplentat = new Implentat();
            _deleteImplentat = CustomerDb.GetImplentationById(ImplentationiD, DatabaseId);
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
            BindImplentationsForCustomer(CustomerId);
        }

        private void radButton8_Click(object sender, EventArgs e)
        {

            Implentat _deleteImplentat = new Implentat();
            _deleteImplentat = CustomerDb.GetImplentationById(ImplentationiD, DatabaseId);
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
            BindImplentationsForCustomer(CustomerId);
        }

        private void btnAddProgramTypes_Click(object sender, EventArgs e)
        {
            frmProgramTypes _frmPrograType = new frmProgramTypes();
            _frmPrograType.ProgramTypeId = ProgramTypeId;
            _frmPrograType.CustomerId = CustomerId;
            _frmPrograType.databaseId = DatabaseId;
            _frmPrograType.IsEditMode = false;
            _frmPrograType.ShowDialog();
        }

        private void rgProgramTypes_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            btnEditProgramTypes_Click(sender, e);
        }

        private void rgAddons_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            btnEditAddon_Click(sender, e);
        }

        private void grdRevenue_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            btnEditRevenue_Click(sender, e);

        }

        private void btnEditRevenue_Click(object sender, EventArgs e)
        {
            frmRevenue _frmRevenue = new frmRevenue();
            _frmRevenue.CustomerId = CustomerId;
            _frmRevenue.RecordId = Revenueid;
            _frmRevenue.IsEdit = true;
            _frmRevenue.ShowDialog();
            BindRevenue(CustomerId);
        }

        private void grdImplentations_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            btnEditImplentation_Click(sender, e);
        }

        private void rgContacts_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            btnEditContact_Click(sender, e);
        }

        private void rgNotes_SelectionChanged(object sender, EventArgs e)
        {
            if (rgNotes.SelectedRows.Count > 0)
            {
                if (rgNotes.CurrentRow.Cells[0].Value != null)
                {
                    this.NotesId = (int)rgNotes.CurrentRow.Cells[0].Value;

                }
            }
        }

        private void btnAddNotes_Click(object sender, EventArgs e)
        {
            frmNotes _frmnotes = new frmNotes();
            _frmnotes.StartPosition = FormStartPosition.CenterScreen;
            _frmnotes.CustomerId = CustomerId;
            _frmnotes.NotesId = NotesId;
            _frmnotes.IsEditMode = false;
            _frmnotes.databaseId = DatabaseId;
            _frmnotes.ShowDialog();
            BindNotes(CustomerId);
        }

        private void btnEditNote_Click(object sender, EventArgs e)
        {
            frmNotes _frmnotes = new frmNotes();
            _frmnotes.StartPosition = FormStartPosition.CenterScreen;
            _frmnotes.CustomerId = CustomerId;
            _frmnotes.NotesId = NotesId;
            _frmnotes.databaseId = DatabaseId;
            _frmnotes.IsEditMode = true;
            _frmnotes.ShowDialog();
            BindNotes(CustomerId);
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            Note _DeleteNote = new Note();
            _DeleteNote = CustomerDb.GetNotesById(NotesId);
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to Delete Note ", "Delete Note", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                CustomerDb.DeleteNote(_DeleteNote);
                BindAddOns(CustomerId);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            BindNotes(CustomerId);
        }

        private void radRibbonBar1_Click(object sender, EventArgs e)
        {

        }
        private FilterDescriptor filterDescriptor;

        private void txtboxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                radButtonElement3_Click(sender, e);
            }
        }

        private void radButtonElement3_Click(object sender, EventArgs e)
        {
            if (filterDescriptor == null)
            {
                filterDescriptor = new FilterDescriptor("CustomerName", FilterOperator.Contains, txtboxSearch.Text);
                rgCustomers.FilterDescriptors.Add(filterDescriptor);
            }
            else
            {
                filterDescriptor.Value = txtboxSearch.Text;
            }
        }

        private void btnSearchReset_Click(object sender, EventArgs e)
        {
            this.rgCustomers.MasterTemplate.FilterDescriptors.Clear();
        }

        private void btnEditLookupsCountys_Click(object sender, EventArgs e)
        {
            frmStandardLookupEditor _frmStandardLookupEditor = new frmStandardLookupEditor();
            _frmStandardLookupEditor.LookupType = Costants.CountyList;

            _frmStandardLookupEditor.ShowDialog();


        }

        private void btnUsersEdit_Click(object sender, EventArgs e)
        {
            if (isAdmin == true)
            {
                frmUsers _frmUser = new frmUsers();
                _frmUser.ShowDialog();
            }
            else
                MessageBox.Show(this, "Only admins can modify users. Please contact Nick or an admin.", "Authorization Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);



        }

        private void btnProjectLeads_Click(object sender, EventArgs e)
        {
            frmStandardLookupEditor _frmStandardLookup = new frmStandardLookupEditor();
            _frmStandardLookup.LookupType = Costants.ProjectManagersList;
            _frmStandardLookup.ShowDialog();

        }

        private void btnDataMigration_Click(object sender, EventArgs e)
        {
            frmStandardLookupEditor _frmStandardLookup = new frmStandardLookupEditor();
            _frmStandardLookup.LookupType = Costants.DataMigrationList;
            _frmStandardLookup.ShowDialog();
        }

        private void btnDeleteCustomFields_Click(object sender, EventArgs e)
        {
            CustomField _CustomField = new CustomField();
            _CustomField = CustomerDb.GetCustomFieldById(CutomFieldId);
            DialogResult dialogResult = MessageBox.Show("Delete Custom Field", "Are you sure you wish to CustomField ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                CustomerDb.DeleteCustomField(_CustomField);
                BindAddOns(CustomerId);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            BindCustomFields(CustomerId);
        }

        private void btnCustomFieldEdit_Click(object sender, EventArgs e)
        {
            frmCustomFieldsEditor _frmCustomFieldEdit = new frmCustomFieldsEditor();
            _frmCustomFieldEdit.CustomerId = CustomerId;
            _frmCustomFieldEdit.IsEdit = true;
            _frmCustomFieldEdit.CustomFieldId = CutomFieldId;
            _frmCustomFieldEdit.ShowDialog();
            BindCustomFields(CustomerId);
        }

        private void radPageViewPage9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCustomFieldAdd_Click(object sender, EventArgs e)
        {
            frmCustomFieldsEditor _frmCustomFieldEdit = new frmCustomFieldsEditor();
            _frmCustomFieldEdit.CustomerId = CustomerId;
            _frmCustomFieldEdit.IsEdit = false;
            _frmCustomFieldEdit.CustomFieldId = CutomFieldId;
            _frmCustomFieldEdit.ShowDialog();
            _frmCustomFieldEdit.DatabaseId = DatabaseId;
            BindCustomFields(CustomerId);
        }

        private void rgContracts_SelectionChanged(object sender, EventArgs e)
        {

            if (rgContracts.SelectedRows.Count > 0)
            {
                if (rgContracts.CurrentRow.Cells[0].Value != null)
                {
                    this.ContractId = (int)rgContracts.CurrentRow.Cells[0].Value;

                }
            }
        }

        private void btnAddContracts_Click(object sender, EventArgs e)
        {
            frmContracts _frmContract = new frmContracts();
            _frmContract.StartPosition = FormStartPosition.CenterScreen;
            _frmContract.ContractId = ContractId;
            _frmContract.IsEdit = false;
            _frmContract.CustomerId = CustomerId;
            _frmContract.databaseId = DatabaseId;
            _frmContract.ShowDialog();
            BindContracts(CustomerId);
        }

        private void btnEditContract_Click(object sender, EventArgs e)
        {
            frmContracts _frmContract = new frmContracts();
            _frmContract.StartPosition = FormStartPosition.CenterScreen;
            _frmContract.ContractId = ContractId;
            _frmContract.IsEdit = true;
            _frmContract.databaseId = DatabaseId;
            _frmContract.CustomerId = CustomerId;
            _frmContract.ShowDialog();
            BindContracts(CustomerId);
        }

        private void btnAddRevenue_Click_1(object sender, EventArgs e)
        {
            frmRevenue _frmRevenue = new frmRevenue();
            _frmRevenue.CustomerId = CustomerId;
            _frmRevenue.RecordId = Revenueid;
            _frmRevenue.IsEdit = false;
            _frmRevenue.databaseId = DatabaseId;
            _frmRevenue.ShowDialog();

            BindRevenue(CustomerId);

        }

        private void btnEditRevenue_Click_1(object sender, EventArgs e)
        {
            frmRevenue _frmRevenue = new frmRevenue();
            _frmRevenue.CustomerId = CustomerId;
            _frmRevenue.RecordId = Revenueid;
            _frmRevenue.IsEdit = true;
            _frmRevenue.databaseId = DatabaseId;
            _frmRevenue.ShowDialog();

            BindRevenue(CustomerId);
        }

        private void chkCountyOther_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherCounty.Enabled = chkCountyOther.Checked;
        }

        private void cboDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseId = (int) cboDatabases.SelectedValue;

            BindCustomers();
            lbldatabaseName.Text = CustomerDb.GetDatabaseNames(DatabaseId);
        }
    }
}
