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
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtDescription = new Telerik.WinControls.UI.RadTextBox();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtStatus = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.chkrxnt = new System.Windows.Forms.CheckBox();
            this.chkoqanalyst = new System.Windows.Forms.CheckBox();
            this.chkavaility = new System.Windows.Forms.CheckBox();
            this.Amount = new Telerik.WinControls.UI.RadLabel();
            this.txtAmount = new Telerik.WinControls.UI.RadMaskedEditBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 21);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(2, 2);
            this.radLabel2.TabIndex = 9;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(144, 19);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(186, 20);
            this.txtDescription.TabIndex = 0;
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(500, 176);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(110, 24);
            this.radButton2.TabIndex = 7;
            this.radButton2.Text = "Cancel";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(371, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(12, 19);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(63, 18);
            this.radLabel3.TabIndex = 21;
            this.radLabel3.Text = "Description";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(144, 100);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(186, 20);
            this.txtStatus.TabIndex = 2;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(12, 102);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(37, 18);
            this.radLabel4.TabIndex = 23;
            this.radLabel4.Text = "Status";
            // 
            // chkrxnt
            // 
            this.chkrxnt.AutoSize = true;
            this.chkrxnt.Location = new System.Drawing.Point(144, 139);
            this.chkrxnt.Name = "chkrxnt";
            this.chkrxnt.Size = new System.Drawing.Size(54, 17);
            this.chkrxnt.TabIndex = 3;
            this.chkrxnt.Text = "RxNT";
            this.chkrxnt.UseVisualStyleBackColor = true;
            // 
            // chkoqanalyst
            // 
            this.chkoqanalyst.AutoSize = true;
            this.chkoqanalyst.Location = new System.Drawing.Point(225, 139);
            this.chkoqanalyst.Name = "chkoqanalyst";
            this.chkoqanalyst.Size = new System.Drawing.Size(79, 17);
            this.chkoqanalyst.TabIndex = 4;
            this.chkoqanalyst.Text = "OQ Analyst";
            this.chkoqanalyst.UseVisualStyleBackColor = true;
            // 
            // chkavaility
            // 
            this.chkavaility.AutoSize = true;
            this.chkavaility.Location = new System.Drawing.Point(310, 139);
            this.chkavaility.Name = "chkavaility";
            this.chkavaility.Size = new System.Drawing.Size(59, 17);
            this.chkavaility.TabIndex = 5;
            this.chkavaility.Text = "Availity";
            this.chkavaility.UseVisualStyleBackColor = true;
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(12, 61);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(47, 18);
            this.Amount.TabIndex = 28;
            this.Amount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(144, 61);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(125, 20);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.TabStop = false;
            // 
            // frmAddon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 210);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.chkavaility);
            this.Controls.Add(this.chkoqanalyst);
            this.Controls.Add(this.chkrxnt);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.MaximizeBox = false;
            this.Name = "frmAddon";
            this.Text = "Add Ons";
            this.Load += new System.EventHandler(this.frmAddon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtDescription;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtStatus;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private System.Windows.Forms.CheckBox chkrxnt;
        private System.Windows.Forms.CheckBox chkoqanalyst;
        private System.Windows.Forms.CheckBox chkavaility;
        private Telerik.WinControls.UI.RadLabel Amount;
        private Telerik.WinControls.UI.RadMaskedEditBox txtAmount;
    }
}