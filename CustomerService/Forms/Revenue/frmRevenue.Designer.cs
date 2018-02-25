namespace CustomerService.Forms.Revenue
{
    partial class frmRevenue
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
            this.rdPriceFixedUnitl = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtUsers = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.txtRevenue = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.cboYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdPriceFixedUnitl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(3, 94);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(86, 18);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "Price Fixed Unitl";
            // 
            // rdPriceFixedUnitl
            // 
            this.rdPriceFixedUnitl.Location = new System.Drawing.Point(119, 91);
            this.rdPriceFixedUnitl.Name = "rdPriceFixedUnitl";
            this.rdPriceFixedUnitl.Size = new System.Drawing.Size(164, 20);
            this.rdPriceFixedUnitl.TabIndex = 2;
            this.rdPriceFixedUnitl.TabStop = false;
            this.rdPriceFixedUnitl.Text = "21 February 2018";
            this.rdPriceFixedUnitl.Value = new System.DateTime(2018, 2, 21, 19, 54, 23, 187);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(422, 218);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(110, 24);
            this.radButton2.TabIndex = 5;
            this.radButton2.Text = "Cancel";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(306, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(3, 12);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(28, 18);
            this.radLabel3.TabIndex = 21;
            this.radLabel3.Text = "Year";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(3, 52);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(33, 18);
            this.radLabel4.TabIndex = 23;
            this.radLabel4.Text = "Users";
            // 
            // txtUsers
            // 
            this.txtUsers.Location = new System.Drawing.Point(119, 51);
            this.txtUsers.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(125, 20);
            this.txtUsers.TabIndex = 1;
            this.txtUsers.TabStop = false;
            this.txtUsers.Text = "0";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(3, 134);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(49, 18);
            this.radLabel5.TabIndex = 7;
            this.radLabel5.Text = "Revenue";
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(119, 134);
            this.txtRevenue.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(125, 20);
            this.txtRevenue.TabIndex = 3;
            this.txtRevenue.TabStop = false;
            this.txtRevenue.Text = "0";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(101, 136);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(12, 18);
            this.radLabel6.TabIndex = 26;
            this.radLabel6.Text = "$";
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(119, 13);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 21);
            this.cboYear.TabIndex = 0;
            // 
            // frmRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 253);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.txtUsers);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdPriceFixedUnitl);
            this.Controls.Add(this.radLabel2);
            this.Name = "frmRevenue";
            this.Text = "Revenue";
            this.Load += new System.EventHandler(this.frmRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdPriceFixedUnitl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker rdPriceFixedUnitl;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadMaskedEditBox txtUsers;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadMaskedEditBox txtRevenue;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private System.Windows.Forms.ComboBox cboYear;
    }
}