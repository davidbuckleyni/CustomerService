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
using Telerik.WinControls.UI;

namespace CustomerService.Forms.CustomFields
{
    public partial class frmCustomFieldsEditor : Form
    {
        CustomersContext _db = new CustomersContext();
        public int LookupType { get; set; }
        public int ControlId { get; set; }
    
        public bool IsEdit { get; set; }
        public int CustomFieldId { get; set; }
        public int CustomerId { get; set; }
        public int DatabaseId { get; set; }
        public frmCustomFieldsEditor()
        {
            InitializeComponent();
        }

        private void frmCustomFieldsEditor_Load(object sender, EventArgs e)
        {

            CustomField _newCustomField = new CustomField();
            if (IsEdit == true)
            {
                _newCustomField = _db.GetCustomFieldById(this.CustomFieldId);

                txtFieldValue.Text = _newCustomField.FieldValue;
                txtName.Text = _newCustomField.FieldName;
                rdTableName.Text = _newCustomField.TableName.ToString();

            }

        }

        private void btnAddControl_Click(object sender, EventArgs e)
        {  
    
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CustomField _newCustomField = new CustomField();
                if (IsEdit == true)
                    _newCustomField = _db.GetCustomFieldById(this.CustomFieldId);

                _newCustomField.FieldName = txtName.Text;
             
                _newCustomField.FieldValue = txtFieldValue.Text;
                _newCustomField.TableName = rdTableName.Text;
                _newCustomField.CustomerId = CustomerId;
                _newCustomField.databaseID = DatabaseId;

                if (IsEdit == true)
                {

                    _db.SaveCustomFields(_newCustomField);
                    _db.SaveChanges();
                    MessageBox.Show("Custom Fields has been Update", "Custom Fields Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                  

                    _db.AddToCustomFields(_newCustomField);
                    _db.SaveChanges();
                    MessageBox.Show("Custom Fields has been Created", "Custom Fields Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }catch(Exception ex)
            {


            }

        }
    }
}
