namespace CustomerService.Forms.Users
{
    partial class frmUsersEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtpassword = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtUserName = new Telerik.WinControls.UI.RadTextBox();
            this.btnEditUser = new Telerik.WinControls.UI.RadButton();
            this.btnAddUser = new Telerik.WinControls.UI.RadButton();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.isAdmin = new System.Windows.Forms.CheckBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtFullename = new Telerik.WinControls.UI.RadTextBox();
            this.isActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullename)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(158, 89);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(186, 20);
            this.txtpassword.TabIndex = 2;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(26, 91);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(53, 18);
            this.radLabel2.TabIndex = 13;
            this.radLabel2.Text = "Password";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(26, 45);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(56, 18);
            this.radLabel1.TabIndex = 12;
            this.radLabel1.Text = "Username";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(158, 45);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(186, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(298, 194);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(110, 24);
            this.btnEditUser.TabIndex = 6;
            this.btnEditUser.Text = "Cancel";
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(182, 194);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(110, 24);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Save  User";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(158, 125);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.PasswordChar = '*';
            this.radTextBox1.Size = new System.Drawing.Size(186, 20);
            this.radTextBox1.TabIndex = 3;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(26, 126);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(96, 18);
            this.radLabel3.TabIndex = 17;
            this.radLabel3.Text = "Confirm Password";
            // 
            // isAdmin
            // 
            this.isAdmin.AutoSize = true;
            this.isAdmin.Location = new System.Drawing.Point(158, 167);
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Size = new System.Drawing.Size(55, 17);
            this.isAdmin.TabIndex = 4;
            this.isAdmin.Text = "Admin";
            this.isAdmin.UseVisualStyleBackColor = true;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(26, 12);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(54, 18);
            this.radLabel4.TabIndex = 20;
            this.radLabel4.Text = "FullName";
            // 
            // txtFullename
            // 
            this.txtFullename.Location = new System.Drawing.Point(158, 12);
            this.txtFullename.Name = "txtFullename";
            this.txtFullename.Size = new System.Drawing.Size(186, 20);
            this.txtFullename.TabIndex = 0;
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Location = new System.Drawing.Point(219, 167);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(56, 17);
            this.isActive.TabIndex = 5;
            this.isActive.Text = "Active";
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // frmUsersEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 248);
            this.Controls.Add(this.isActive);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.txtFullename);
            this.Controls.Add(this.isAdmin);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtUserName);
            this.MaximizeBox = false;
            this.Name = "frmUsersEdit";
            this.Text = "Users ";
            this.Load += new System.EventHandler(this.frmUsersEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullename)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtpassword;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtUserName;
        private Telerik.WinControls.UI.RadButton btnEditUser;
        private Telerik.WinControls.UI.RadButton btnAddUser;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.CheckBox isAdmin;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txtFullename;
        private System.Windows.Forms.CheckBox isActive;
    }
}