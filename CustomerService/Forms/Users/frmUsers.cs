using CustomerService.Classes;
using CustomerService.Forms.Search;
using CustomerService.Forms.Users;
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
    public partial class frmUsers : Form
    {
        public int UserId { get; set; }
        public int ProgramTypeId { get; set; }
        public bool IsEditMode { get; set; }
        CustomersContext _db = new CustomersContext();
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDbDataSet12.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.customerDbDataSet12.Users);



            BindUsers();



        }

        private void BindUsers()
        {

            grdUsers.DataSource = _db.GetAllUsers();

        }

        private void grdUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (grdUsers.SelectedRows.Count > 0)
            {
                if (grdUsers.CurrentRow.Cells[0].Value != null)
                {
                    this.UserId = (int)grdUsers.CurrentRow.Cells[0].Value;

                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmUsersEdit _frmUserEdit = new frmUsersEdit();
            _frmUserEdit.UserId = UserId;
            _frmUserEdit.IsEditMode = false;
            _frmUserEdit.ShowDialog();
            BindUsers();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            frmUsersEdit _frmUserEdit = new frmUsersEdit();
            _frmUserEdit.UserId = UserId;
            _frmUserEdit.IsEditMode = true;
            _frmUserEdit.ShowDialog();
            BindUsers();
        }
    }
}
