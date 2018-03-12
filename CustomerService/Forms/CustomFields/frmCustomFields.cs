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

namespace CustomerService.Forms.CustomFields
{
    public partial class frmCustomFields : Form
    {
        CustomersContext _db = new CustomersContext();
        public int LookupType { get; set; }
        public int LookupId { get; set; }
        public int  CustomerId { get; set; }
        public int CutomFieldId { get; set; }
        public int databaseID { get; set; }
        public frmCustomFields()
        {
            InitializeComponent();
        }

        private void frmCustomFields_Load(object sender, EventArgs e)
        {
      
            grdCustomFields.DataSource = _db.GetAllCustomFields(databaseID);
            
        }

        private void btnAddCustomField_Click(object sender, EventArgs e)
        {
            frmCustomFieldsEditor _frmCustomFieldEdit = new frmCustomFieldsEditor();
            _frmCustomFieldEdit.CustomerId = CustomerId;
            _frmCustomFieldEdit.IsEdit = false;
            _frmCustomFieldEdit.CustomFieldId = CutomFieldId;
            _frmCustomFieldEdit.ShowDialog();
        }

        private void grdCustomFields_SelectionChanged(object sender, EventArgs e)
        {
            if (grdCustomFields.SelectedRows.Count > 0)
            {
                if (grdCustomFields.CurrentRow.Cells[0].Value != null)
                {
                    this.CutomFieldId = (int)grdCustomFields.CurrentRow.Cells[0].Value;

                }
            }
        }

        private void btnEditCustomField_Click(object sender, EventArgs e)
        {
            {
                frmCustomFieldsEditor _frmCustomFieldEdit = new frmCustomFieldsEditor();
                _frmCustomFieldEdit.CustomerId = CustomerId;
                _frmCustomFieldEdit.IsEdit = true;
                _frmCustomFieldEdit.CustomFieldId = CutomFieldId;
                _frmCustomFieldEdit.ShowDialog();
            }
        }
    }
}
