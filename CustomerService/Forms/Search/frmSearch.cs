using CustomerService.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomerService.Forms.Search
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }
        CustomersContext _db = new CustomersContext();
        public int SearchType { get; set; }
        public int ReturnId { get; set; }
        public string   ReturnString { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        private void frmSearch_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            
            switch (SearchType)
            {
                case 1: //customers
                    grdSearch.DataSource = _db.GetAlCustomersForSearch();
                    break;
                case 2: //databases
                    this.Text = "Please select Database";
                     grdSearch.DataSource = _db.GetAllDatabasesForSearchByUser(UserId);                                  
                     break;
                    
              
            }


        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            switch (SearchType)
            {
                case 1: //customers

                    break;

                case 2://database
                    ReturnId = (int)grdSearch.CurrentRow.Cells["Code"].Value;
                    ReturnString = grdSearch.CurrentRow.Cells["Description"].Value.ToString();
                    break;

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
