namespace CustomerService.Forms.Contacts
{
    partial class frmContact
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
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtPhone = new Telerik.WinControls.UI.RadTextBox();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.isPrimary = new Telerik.WinControls.UI.RadToggleSwitch();
            this.cboPrimaryContact = new System.Windows.Forms.ComboBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isPrimary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(99, 102);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(38, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Phone";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(104, 139);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(33, 18);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "Email";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(51, 179);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(86, 18);
            this.radLabel4.TabIndex = 4;
            this.radLabel4.Text = "Primary Contact";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(167, 102);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(186, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(167, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(284, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // isPrimary
            // 
            this.isPrimary.Location = new System.Drawing.Point(167, 177);
            this.isPrimary.Name = "isPrimary";
            this.isPrimary.Size = new System.Drawing.Size(86, 20);
            this.isPrimary.TabIndex = 4;
            this.isPrimary.Text = "radToggleSwitch1";
            // 
            // cboPrimaryContact
            // 
            this.cboPrimaryContact.FormattingEnabled = true;
            this.cboPrimaryContact.Location = new System.Drawing.Point(167, 12);
            this.cboPrimaryContact.Name = "cboPrimaryContact";
            this.cboPrimaryContact.Size = new System.Drawing.Size(186, 21);
            this.cboPrimaryContact.TabIndex = 0;
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(7, 12);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(130, 18);
            this.radLabel5.TabIndex = 2;
            this.radLabel5.Text = "Pimrary Point Of Contact";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(306, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(422, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 24);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(167, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 20);
            this.txtName.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(101, 62);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(36, 18);
            this.radLabel1.TabIndex = 9;
            this.radLabel1.Text = "Name";
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 279);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.cboPrimaryContact);
            this.Controls.Add(this.isPrimary);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Name = "frmContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.frmContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isPrimary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txtPhone;
        private Telerik.WinControls.UI.RadTextBox txtEmail;
        private Telerik.WinControls.UI.RadToggleSwitch isPrimary;
        private System.Windows.Forms.ComboBox cboPrimaryContact;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}