namespace CustomerService.Forms.ProgramTypes
{
    partial class frmProgramTypes
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
            this.Amount = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtDescription = new Telerik.WinControls.UI.RadTextBox();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtNotes = new Telerik.WinControls.UI.RadRichTextEditor();
            this.chkFosterCare = new System.Windows.Forms.CheckBox();
            this.chkResidential = new System.Windows.Forms.CheckBox();
            this.chkSubstanceAbuse = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(15, 63);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(36, 18);
            this.Amount.TabIndex = 35;
            this.Amount.Text = "Notes";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(15, 21);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(63, 18);
            this.radLabel3.TabIndex = 34;
            this.radLabel3.Text = "Description";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(22, 68);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(2, 2);
            this.radLabel2.TabIndex = 33;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(99, 21);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(186, 20);
            this.txtDescription.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(343, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 24);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(214, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            this.txtNotes.Location = new System.Drawing.Point(99, 74);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtNotes.Size = new System.Drawing.Size(354, 139);
            this.txtNotes.TabIndex = 1;
            // 
            // chkFosterCare
            // 
            this.chkFosterCare.AutoSize = true;
            this.chkFosterCare.Location = new System.Drawing.Point(99, 230);
            this.chkFosterCare.Name = "chkFosterCare";
            this.chkFosterCare.Size = new System.Drawing.Size(80, 17);
            this.chkFosterCare.TabIndex = 2;
            this.chkFosterCare.Text = "Foster Care";
            this.chkFosterCare.UseVisualStyleBackColor = true;
            // 
            // chkResidential
            // 
            this.chkResidential.AutoSize = true;
            this.chkResidential.Location = new System.Drawing.Point(205, 230);
            this.chkResidential.Name = "chkResidential";
            this.chkResidential.Size = new System.Drawing.Size(78, 17);
            this.chkResidential.TabIndex = 3;
            this.chkResidential.Text = "Residential";
            this.chkResidential.UseVisualStyleBackColor = true;
            // 
            // chkSubstanceAbuse
            // 
            this.chkSubstanceAbuse.AutoSize = true;
            this.chkSubstanceAbuse.Location = new System.Drawing.Point(343, 230);
            this.chkSubstanceAbuse.Name = "chkSubstanceAbuse";
            this.chkSubstanceAbuse.Size = new System.Drawing.Size(110, 17);
            this.chkSubstanceAbuse.TabIndex = 4;
            this.chkSubstanceAbuse.Text = "Substance Abuse";
            this.chkSubstanceAbuse.UseVisualStyleBackColor = true;
            // 
            // frmProgramTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 349);
            this.Controls.Add(this.chkSubstanceAbuse);
            this.Controls.Add(this.chkResidential);
            this.Controls.Add(this.chkFosterCare);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txtDescription);
            this.MaximizeBox = false;
            this.Name = "frmProgramTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Types";
            this.Load += new System.EventHandler(this.frmProgramTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel Amount;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtDescription;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadRichTextEditor txtNotes;
        private System.Windows.Forms.CheckBox chkFosterCare;
        private System.Windows.Forms.CheckBox chkResidential;
        private System.Windows.Forms.CheckBox chkSubstanceAbuse;
    }
}