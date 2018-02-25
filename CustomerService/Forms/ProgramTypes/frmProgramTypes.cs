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

namespace CustomerService.Forms.ProgramTypes
{
    public partial class frmProgramTypes : Form
    {
        public int CustomerId { get; set; }
        public int ProgramTypeId { get; set; }
        public bool IsEditMode { get; set; }
        CustomersContext _db = new CustomersContext();

        public frmProgramTypes()
        {
            InitializeComponent();
        }

        private void frmProgramTypes_Load(object sender, EventArgs e)
        {
            ProgamType _newProgType = new ProgamType();
            if (IsEditMode == true)
            {
                _newProgType = _db.GetProgramTypeById(ProgramTypeId);
                txtDescription.Text = _newProgType.ProgramTypesDescription;
                txtNotes.Text = _newProgType.Notes;
                chkStatus.Checked = (bool)_newProgType.ProgramTypeStatus;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProgamType _newProgType = new ProgamType();
            if (IsEditMode == true)
            {
                _newProgType = _db.GetProgramTypeById(ProgramTypeId);
            }
            _newProgType.ProgramTypesDescription = txtDescription.Text;
            _newProgType.Notes = txtNotes.Text;
            _newProgType.CustomerId = CustomerId;
                _newProgType.ProgramTypeStatus = chkStatus.Checked;

            if (IsEditMode == true)
            {
                _db.SaveProgramTypes(_newProgType);
                _db.SaveChanges();

                MessageBox.Show("Program Types Saved", "Program Types has been updated ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                _db.AddToProgramType(_newProgType);
                _db.SaveChanges();
                MessageBox.Show("Program Types Saved", "Program Types has been Created ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
