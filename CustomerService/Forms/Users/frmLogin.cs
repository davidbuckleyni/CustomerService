﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using CustomerService;
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

namespace CustomerService.Forms.Users
{
    public partial class frmLogin : Form
    {
        CustomersContext _db = new CustomersContext();
        public bool IsEdit { get; set; }
        public int CustomerId { get; set; }
        public int RecordId { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if(txtPassword.Text !="")
            {
                User validUser = _db.ValidateUser(txtLogin.Text, txtPassword.Text);
                if (validUser != null && validUser.isActive == true)
                {
                    
                    frmCustomerService _frmCustomerService = new frmCustomerService();
                    _frmCustomerService.isAdmin = (bool)validUser.isAdmin;
                    _frmCustomerService.ShowDialog();
                    Cursor.Current = Cursors.Default;
                }
                else
                    MessageBox.Show("Invalid Login", "Sorry the login information was incorrect, Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                this.Close();
            }


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

        }
    }
}