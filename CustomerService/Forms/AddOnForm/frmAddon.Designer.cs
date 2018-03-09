namespace CustomerService.Forms.AddOnForm
{
    partial class frmAddon
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.chkrxnt = new System.Windows.Forms.CheckBox();
            this.chkoqanalyst = new System.Windows.Forms.CheckBox();
            this.chkavaility = new System.Windows.Forms.CheckBox();
            this.lblperiscopeAmount = new Telerik.WinControls.UI.RadLabel();
            this.txtPeriScopeAmount = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.cboPeriscopeStatus = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblperiscopeAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriScopeAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPeriscopeStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(501, 134);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(110, 24);
            this.radButton2.TabIndex = 7;
            this.radButton2.Text = "Cancel";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(372, 134);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkrxnt
            // 
            this.chkrxnt.AutoSize = true;
            this.chkrxnt.Location = new System.Drawing.Point(144, 90);
            this.chkrxnt.Name = "chkrxnt";
            this.chkrxnt.Size = new System.Drawing.Size(54, 17);
            this.chkrxnt.TabIndex = 3;
            this.chkrxnt.Text = "RxNT";
            this.chkrxnt.UseVisualStyleBackColor = true;
            // 
            // chkoqanalyst
            // 
            this.chkoqanalyst.AutoSize = true;
            this.chkoqanalyst.Location = new System.Drawing.Point(225, 90);
            this.chkoqanalyst.Name = "chkoqanalyst";
            this.chkoqanalyst.Size = new System.Drawing.Size(79, 17);
            this.chkoqanalyst.TabIndex = 4;
            this.chkoqanalyst.Text = "OQ Analyst";
            this.chkoqanalyst.UseVisualStyleBackColor = true;
            // 
            // chkavaility
            // 
            this.chkavaility.AutoSize = true;
            this.chkavaility.Location = new System.Drawing.Point(310, 90);
            this.chkavaility.Name = "chkavaility";
            this.chkavaility.Size = new System.Drawing.Size(59, 17);
            this.chkavaility.TabIndex = 5;
            this.chkavaility.Text = "Availity";
            this.chkavaility.UseVisualStyleBackColor = true;
            // 
            // lblperiscopeAmount
            // 
            this.lblperiscopeAmount.Location = new System.Drawing.Point(12, 12);
            this.lblperiscopeAmount.Name = "lblperiscopeAmount";
            this.lblperiscopeAmount.Size = new System.Drawing.Size(113, 18);
            this.lblperiscopeAmount.TabIndex = 28;
            this.lblperiscopeAmount.Text = "Pericope Cost/Month";
            // 
            // txtPeriScopeAmount
            // 
            this.txtPeriScopeAmount.Location = new System.Drawing.Point(144, 12);
            this.txtPeriScopeAmount.Name = "txtPeriScopeAmount";
            this.txtPeriScopeAmount.Size = new System.Drawing.Size(125, 20);
            this.txtPeriScopeAmount.TabIndex = 1;
            this.txtPeriScopeAmount.TabStop = false;
            // 
            // cboPeriscopeStatus
            // 
            radListDataItem1.Text = "Contacts";
            radListDataItem2.Text = "Program Types";
            radListDataItem3.Text = "Addons";
            radListDataItem4.Text = "Customer";
            radListDataItem5.Text = "Revenue";
            this.cboPeriscopeStatus.Items.Add(radListDataItem1);
            this.cboPeriscopeStatus.Items.Add(radListDataItem2);
            this.cboPeriscopeStatus.Items.Add(radListDataItem3);
            this.cboPeriscopeStatus.Items.Add(radListDataItem4);
            this.cboPeriscopeStatus.Items.Add(radListDataItem5);
            this.cboPeriscopeStatus.Location = new System.Drawing.Point(144, 50);
            this.cboPeriscopeStatus.Name = "cboPeriscopeStatus";
            this.cboPeriscopeStatus.Size = new System.Drawing.Size(227, 20);
            this.cboPeriscopeStatus.TabIndex = 29;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 52);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(88, 18);
            this.radLabel1.TabIndex = 30;
            this.radLabel1.Text = "Periscope Status";
            // 
            // frmAddon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 170);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.cboPeriscopeStatus);
            this.Controls.Add(this.txtPeriScopeAmount);
            this.Controls.Add(this.lblperiscopeAmount);
            this.Controls.Add(this.chkavaility);
            this.Controls.Add(this.chkoqanalyst);
            this.Controls.Add(this.chkrxnt);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.Name = "frmAddon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Ons";
            this.Load += new System.EventHandler(this.frmAddon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblperiscopeAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriScopeAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPeriscopeStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.CheckBox chkrxnt;
        private System.Windows.Forms.CheckBox chkoqanalyst;
        private System.Windows.Forms.CheckBox chkavaility;
        private Telerik.WinControls.UI.RadLabel lblperiscopeAmount;
        private Telerik.WinControls.UI.RadMaskedEditBox txtPeriScopeAmount;
        private Telerik.WinControls.UI.RadDropDownList cboPeriscopeStatus;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}