namespace CustomerService.Forms
{
    partial class frmContracts
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
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtBasePrice = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.dtSignOffDate = new System.Windows.Forms.DateTimePicker();
            this.txtNumberOfUsers = new DevExpress.XtraEditors.SpinEdit();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtBaseUsers = new DevExpress.XtraEditors.SpinEdit();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtCostOfExtraUser = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.txtMonthlyCharge = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.txtRRARR = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostOfExtraUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonthlyCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRRARR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(394, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 24);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(261, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(32, 66);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(93, 18);
            this.radLabel3.TabIndex = 28;
            this.radLabel3.Text = "Number Of Users";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(157, 103);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(227, 20);
            this.txtBasePrice.TabIndex = 2;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(48, 30);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(77, 18);
            this.radLabel2.TabIndex = 26;
            this.radLabel2.Text = "SignOffGoLive";
            // 
            // dtSignOffDate
            // 
            this.dtSignOffDate.Location = new System.Drawing.Point(157, 30);
            this.dtSignOffDate.Name = "dtSignOffDate";
            this.dtSignOffDate.Size = new System.Drawing.Size(200, 20);
            this.dtSignOffDate.TabIndex = 0;
            // 
            // txtNumberOfUsers
            // 
            this.txtNumberOfUsers.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNumberOfUsers.Location = new System.Drawing.Point(157, 63);
            this.txtNumberOfUsers.Name = "txtNumberOfUsers";
            this.txtNumberOfUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNumberOfUsers.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfUsers.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(69, 104);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(56, 18);
            this.radLabel1.TabIndex = 35;
            this.radLabel1.Text = "Base Price";
            // 
            // txtBaseUsers
            // 
            this.txtBaseUsers.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtBaseUsers.Location = new System.Drawing.Point(157, 141);
            this.txtBaseUsers.Name = "txtBaseUsers";
            this.txtBaseUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBaseUsers.Size = new System.Drawing.Size(100, 20);
            this.txtBaseUsers.TabIndex = 3;
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(65, 144);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(60, 18);
            this.radLabel5.TabIndex = 36;
            this.radLabel5.Text = "Base Users";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(26, 188);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(99, 18);
            this.radLabel4.TabIndex = 38;
            this.radLabel4.Text = "Cost OF Extra User";
            // 
            // txtCostOfExtraUser
            // 
            this.txtCostOfExtraUser.Location = new System.Drawing.Point(157, 186);
            this.txtCostOfExtraUser.Name = "txtCostOfExtraUser";
            this.txtCostOfExtraUser.Size = new System.Drawing.Size(227, 20);
            this.txtCostOfExtraUser.TabIndex = 4;
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(38, 226);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(87, 18);
            this.radLabel6.TabIndex = 39;
            this.radLabel6.Text = "Monthly Charge";
            // 
            // txtMonthlyCharge
            // 
            this.txtMonthlyCharge.Location = new System.Drawing.Point(157, 226);
            this.txtMonthlyCharge.Name = "txtMonthlyCharge";
            this.txtMonthlyCharge.Size = new System.Drawing.Size(227, 20);
            this.txtMonthlyCharge.TabIndex = 5;
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(84, 263);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(41, 18);
            this.radLabel7.TabIndex = 41;
            this.radLabel7.Text = "RRARR";
            // 
            // txtRRARR
            // 
            this.txtRRARR.Location = new System.Drawing.Point(157, 263);
            this.txtRRARR.Name = "txtRRARR";
            this.txtRRARR.Size = new System.Drawing.Size(227, 20);
            this.txtRRARR.TabIndex = 6;
            // 
            // frmContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 366);
            this.Controls.Add(this.txtRRARR);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.txtMonthlyCharge);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.txtCostOfExtraUser);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.txtBaseUsers);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtNumberOfUsers);
            this.Controls.Add(this.dtSignOffDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.radLabel2);
            this.Name = "frmContracts";
            this.Text = "Contracts";
            this.Load += new System.EventHandler(this.frmContracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostOfExtraUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonthlyCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRRARR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtBasePrice;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.DateTimePicker dtSignOffDate;
        private DevExpress.XtraEditors.SpinEdit txtNumberOfUsers;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private DevExpress.XtraEditors.SpinEdit txtBaseUsers;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txtCostOfExtraUser;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadTextBox txtMonthlyCharge;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadTextBox txtRRARR;
    }
}