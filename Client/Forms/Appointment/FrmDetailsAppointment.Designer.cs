namespace Client.Forms.Term
{
    partial class FrmDetailsAppointment
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
            this.btnSave.Location = new System.Drawing.Point(210, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(167, 147);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(135, 24);
            this.cmbGroup.TabIndex = 19;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(167, 105);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(135, 22);
            this.txtTime.TabIndex = 18;
            // 
            // txtNumOfTerms
            // 
            this.txtNumOfTerms.Location = new System.Drawing.Point(167, 59);
            this.txtNumOfTerms.Name = "txtNumOfTerms";
            this.txtNumOfTerms.Size = new System.Drawing.Size(135, 22);
            this.txtNumOfTerms.TabIndex = 17;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(55, 150);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(47, 16);
            this.lblGroup.TabIndex = 16;
            this.lblGroup.Text = "Grupa:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(55, 105);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(97, 16);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "Vreme termina:";
            // 
            // lblNumOfTerms
            // 
            this.lblNumOfTerms.AutoSize = true;
            this.lblNumOfTerms.Location = new System.Drawing.Point(55, 59);
            this.lblNumOfTerms.Name = "lblNumOfTerms";
            this.lblNumOfTerms.Size = new System.Drawing.Size(81, 16);
            this.lblNumOfTerms.TabIndex = 14;
            this.lblNumOfTerms.Text = "Broj termina:";
            // 
            // FrmDetailsTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 327);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtNumOfTerms);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNumOfTerms);
            this.Name = "FrmDetailsTerm";
            this.Text = "FrmDetailsTerm";
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