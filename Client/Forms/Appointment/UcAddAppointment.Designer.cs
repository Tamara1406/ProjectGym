namespace Client.Forms.Term
{
    partial class UcAddAppointment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtNumOfTerms = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblNumOfTerms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(222, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(179, 150);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(135, 24);
            this.cmbGroup.TabIndex = 12;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(179, 108);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(135, 22);
            this.txtTime.TabIndex = 11;
            // 
            // txtNumOfTerms
            // 
            this.txtNumOfTerms.Location = new System.Drawing.Point(179, 62);
            this.txtNumOfTerms.Name = "txtNumOfTerms";
            this.txtNumOfTerms.Size = new System.Drawing.Size(135, 22);
            this.txtNumOfTerms.TabIndex = 10;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(67, 153);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(47, 16);
            this.lblGroup.TabIndex = 9;
            this.lblGroup.Text = "Grupa:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(67, 108);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(97, 16);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Vreme termina:";
            // 
            // lblNumOfTerms
            // 
            this.lblNumOfTerms.AutoSize = true;
            this.lblNumOfTerms.Location = new System.Drawing.Point(67, 62);
            this.lblNumOfTerms.Name = "lblNumOfTerms";
            this.lblNumOfTerms.Size = new System.Drawing.Size(81, 16);
            this.lblNumOfTerms.TabIndex = 7;
            this.lblNumOfTerms.Text = "Broj termina:";
            // 
            // UcAddTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtNumOfTerms);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNumOfTerms);
            this.Name = "UcAddTerm";
            this.Size = new System.Drawing.Size(420, 305);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtNumOfTerms;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblNumOfTerms;
    }
}
