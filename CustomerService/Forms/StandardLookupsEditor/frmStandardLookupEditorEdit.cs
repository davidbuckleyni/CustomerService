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
    public partial class frmStandardLookupEditorEdit : Form
    {
        CustomersContext _db = new CustomersContext();
        public bool IsEdit { get; set; }
        public int LookupId { get; set; }
        public int LookupGroup { get; set; }

        public frmStandardLookupEditorEdit()
        {
            InitializeComponent();
        }

        private void frmStandardLookupEditorEdit_Load(object sender, EventArgs e)
        {



            if(IsEdit==true)
            {
                StandardLookup _lookup = new StandardLookup();
                _lookup = _db.GetLookupById(this.LookupId);
                txtCode.Text = _lookup.code;
                txtDescription.Text=_lookup.description;


            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            StandardLookup _lookup = new StandardLookup();
            if(IsEdit ==true)
                _lookup = _db.GetLookupById(this.LookupId);

            _lookup.code = txtCode.Text;
            _lookup.description = txtDescription.Text;
            _lookup.lookupgroup = LookupGroup;
            _lookup.isActive = true;
            if(IsEdit==true)
            {
                _db.SaveLookup(_lookup);
                _db.SaveChanges();
                MessageBox.Show("Lookup Saved", "Lookup has been updated ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                _db.AddToLookups(_lookup);
                _db.SaveChanges();
                MessageBox.Show("Lookup Saved", "Lookup has been Created ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            this.Close();

        }
    }
}
