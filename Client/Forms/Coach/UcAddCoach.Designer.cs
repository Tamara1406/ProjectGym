namespace Client.Forms.Coach
{
    partial class UcAddCoach
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
            this.cmbEducation = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEducation = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(247, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 37);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Sacuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbEducation
            // 
            this.cmbEducation.FormattingEnabled = true;
            this.cmbEducation.Location = new System.Drawing.Point(228, 205);
            this.cmbEducation.Name = "cmbEducation";
            this.cmbEducation.Size = new System.Drawing.Size(139, 24);
            this.cmbEducation.TabIndex = 19;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(228, 143);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(139, 22);
            this.txtLastName.TabIndex = 18;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(228, 83);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(139, 22);
            this.txtFirstName.TabIndex = 17;
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Location = new System.Drawing.Point(53, 214);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(131, 16);
            this.lblEducation.TabIndex = 16;
            this.lblEducation.Text = "Stepen obrazovanja:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(53, 150);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(96, 16);
            this.lblLastName.TabIndex = 15;
            this.lblLastName.Text = "Unesi prezime:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(53, 90);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 16);
            this.lblFirstName.TabIndex = 14;
            this.lblFirstName.Text = "Unesi ime:";
            // 
            // UcAddCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbEducation);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "UcAddCoach";
            this.Size = new System.Drawing.Size(422, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbEducation;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
    }
}
