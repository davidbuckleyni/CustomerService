namespace CustomerService.Forms.Implementation
{
    partial class frmImplementation
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
            this.txtOldEhr = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtFee = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.chkIsPaid = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.cboProjectManager = new System.Windows.Forms.ComboBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.cboDataMIgrationLead = new System.Windows.Forms.ComboBox();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radMaskedEditBox1 = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.chkIsLive = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldEhr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMaskedEditBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOldEhr
            // 
            this.txtOldEhr.Location = new System.Drawing.Point(140, 10);
            this.txtOldEhr.Name = "txtOldEhr";
            this.txtOldEhr.Size = new System.Drawing.Size(186, 20);
            this.txtOldEhr.TabIndex = 0;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(8, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(48, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Old EHR";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(140, 55);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(89, 20);
            this.txtFee.TabIndex = 1;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(8, 56);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(106, 18);
            this.radLabel3.TabIndex = 7;
            this.radLabel3.Text = "Implementation Fee";
            // 
            // chkIsPaid
            // 
            this.chkIsPaid.Location = new System.Drawing.Point(207, 215);
            this.chkIsPaid.Name = "chkIsPaid";
            this.chkIsPaid.Size = new System.Drawing.Size(53, 18);
            this.chkIsPaid.TabIndex = 7;
            this.chkIsPaid.Text = "Is Paid";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(8, 89);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(89, 18);
            this.radLabel5.TabIndex = 9;
            this.radLabel5.Text = "Project Manager";
            // 
            // cboProjectManager
            // 
            this.cboProjectManager.FormattingEnabled = true;
            this.cboProjectManager.Location = new System.Drawing.Point(139, 94);
            this.cboProjectManager.Name = "cboProjectManager";
            this.cboProjectManager.Size = new System.Drawing.Size(186, 21);
            this.cboProjectManager.TabIndex = 3;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(8, 134);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(108, 18);
            this.radLabel4.TabIndex = 11;
            this.radLabel4.Text = "Data Migration Lead";
            // 
            // cboDataMIgrationLead
            // 
            this.cboDataMIgrationLead.FormattingEnabled = true;
            this.cboDataMIgrationLead.Location = new System.Drawing.Point(139, 139);
            this.cboDataMIgrationLead.Name = "cboDataMIgrationLead";
            this.cboDataMIgrationLead.Size = new System.Drawing.Size(186, 21);
            this.cboDataMIgrationLead.TabIndex = 4;
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(488, 247);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(110, 24);
            this.radButton2.TabIndex = 9;
            this.radButton2.Text = "Cancel";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(353, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radMaskedEditBox1
            // 
            this.radMaskedEditBox1.Location = new System.Drawing.Point(251, 53);
            this.radMaskedEditBox1.Name = "radMaskedEditBox1";
            this.radMaskedEditBox1.Size = new System.Drawing.Size(125, 20);
            this.radMaskedEditBox1.TabIndex = 2;
            this.radMaskedEditBox1.TabStop = false;
            // 
            // chkIsLive
            // 
            this.chkIsLive.Location = new System.Drawing.Point(139, 215);
            this.chkIsLive.Name = "chkIsLive";
            this.chkIsLive.Size = new System.Drawing.Size(51, 18);
            this.chkIsLive.TabIndex = 6;
            this.chkIsLive.Text = "Is Live";
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(122, 56);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(12, 18);
            this.radLabel7.TabIndex = 27;
            this.radLabel7.Text = "$";
            // 
            // frmImplementation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 284);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.chkIsLive);
            this.Controls.Add(this.radMaskedEditBox1);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.cboDataMIgrationLead);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.cboProjectManager);
            this.Controls.Add(this.chkIsPaid);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txtOldEhr);
            this.MaximizeBox = false;
            this.Name = "frmImplementation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Implementation";
            this.Load += new System.EventHandler(this.frmImplementation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOldEhr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMaskedEditBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadTextBox txtOldEhr;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtFee;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadCheckBox chkIsPaid;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private System.Windows.Forms.ComboBox cboProjectManager;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private System.Windows.Forms.ComboBox cboDataMIgrationLead;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadMaskedEditBox radMaskedEditBox1;
        private Telerik.WinControls.UI.RadCheckBox chkIsLive;
        private Telerik.WinControls.UI.RadLabel radLabel7;
    }
}