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
namespace CustomerService.Forms.Users
{
    public partial class frmUsersEdit : Form
    {
        public int UserId { get; set; }
        
        public bool IsEditMode { get; set; }
        CustomersContext _db = new CustomersContext();

        public frmUsersEdit()
        {
            InitializeComponent();
        }

        private void frmUsersEdit_Load(object sender, EventArgs e)
        {
            if(IsEditMode ==true)
            {
                User _user = new User();
                _user = _db.GetUserById(UserId);
                txtUserName.Text = _user.UserName;
                txtpassword.Text = _user.Pasword;
                isAdmin.Checked =(bool) _user.isAdmin;
                txtFullename.Text = _user.FullName;
                isActive.Checked = (bool)_user.isActive;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User _user = new User();

            if (IsEditMode == true)
            {
                _user = _db.GetUserById(UserId);
            }
            _user.UserName = txtUserName.Text;
            _user.Pasword = txtpassword.Text;
            _user.FullName = txtFullename.Text;
            _user.isAdmin = isAdmin.Checked;
            _user.isActive = isActive.Checked;

            if (IsEditMode == true)
            {

                _db.SaveUser(_user);
                _db.SaveChanges();
                MessageBox.Show("User(s) Saved", "User(s) has been updated ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {

                _db.AddToUsers(_user);
                _db.SaveChanges();
                MessageBox.Show("User(s) Saved", "User(s) has been Created ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            this.Close();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
