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

namespace CustomerService.Forms.StandardLookupsEditor
{
    public partial class frmStandardLookupEditor : Form
    {

        CustomersContext _db = new CustomersContext();
        public int LookupType { get; set; }
        public int LookupId { get; set; }

        public frmStandardLookupEditor()
        {
            InitializeComponent();
        }

        private void frmStandardLookupEditor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDbDataSet11.StandardLookups' table. You can move, or remove it, as needed.
            this.standardLookupsTableAdapter1.Fill(this.customerDbDataSet11.StandardLookups);
            // TODO: This line of code loads data into the 'customerDbDataSet10.StandardLookups' table. You can move, or remove it, as needed.
            this.standardLookupsTableAdapter.Fill(this.customerDbDataSet10.StandardLookups);
            switch (LookupType)
            {
                case Costants.PositionsList:
                    grdLookups.DataSource = _db.GetStandardLookupByGroup(Costants.PositionsList);
                    break;
                case Costants.DataMigrationList:
                    grdLookups.DataSource = _db.GetStandardLookupByGroup(Costants.DataMigrationList);
                    break;
                case Costants.CountyList:
                    grdLookups.DataSource = _db.GetStandardLookupByGroup(Costants.CountyList);
                    break;
                default:
                    grdLookups.DataSource = _db.GetStandardLookupByGroup(LookupType);
                    break;
            }
        }

        public void BindLookups()
        {

            switch (LookupType)
            {
                case Costants.PositionsList:
                    grdLookups.DataSource = _db.GetStandardLookupByGroup(Costants.PositionsList);
                    break;
                case Costants.DataMigrationList:
                    grdLookups.DataSource = _db.GetStandardLookupByGroup(Costants.DataMigrationList);
                    break;
                case Costants.CountyList:
                    grdLookups.DataSource = _db.GetStandardLookupByGroup(Costants.CountyList);
                    break;
                default:
                    grdLookups.DataSource = _db.GetStandardLookupByGroup(LookupType);
                    break;
            }
        }

    

        private void bntEditLookup_Click(object sender, EventArgs e)
        {
            frmStandardLookupEditorEdit _frmEdit = new frmStandardLookupEditorEdit();
            _frmEdit.LookupId = LookupId;
            _frmEdit.LookupGroup = LookupType;
            _frmEdit.IsEdit = true;
            _frmEdit.ShowDialog();
            BindLookups();
        }

        private void btnAddLookup_Click(object sender, EventArgs e)
        {
            frmStandardLookupEditorEdit _frmEdit = new frmStandardLookupEditorEdit();
            _frmEdit.LookupId = LookupId;
            _frmEdit.LookupGroup = LookupType;
            _frmEdit.IsEdit = false;
            _frmEdit.ShowDialog();
            BindLookups();
        }

        private void grdLookups_SelectionChanged(object sender, EventArgs e)
        {
            if (grdLookups.SelectedRows.Count > 0)
            {
                if (grdLookups.CurrentRow.Cells[0].Value != null)
                {
                    this.LookupId = (int)grdLookups.CurrentRow.Cells[0].Value;

                }
            }
        }
    }
}
