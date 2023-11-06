namespace Client.Forms.Coach
{
    partial class FrmCoachDetails
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
            this.btnDeleteCoach = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbEducation = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEducation = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteCoach
            // 
            this.btnDeleteCoach.Location = new System.Drawing.Point(159, 270);
            this.btnDeleteCoach.Name = "btnDeleteCoach";
            this.btnDeleteCoach.Size = new System.Drawing.Size(115, 36);
            this.btnDeleteCoach.TabIndex = 15;
            this.btnDeleteCoach.Text = "Obrisi trenera";
            this.btnDeleteCoach.UseVisualStyleBackColor = true;
            this.btnDeleteCoach.Click += new System.EventHandler(this.btnDeleteCoach_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(302, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 36);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Sacuvaj izmene";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbEducation
            // 
            this.cmbEducation.FormattingEnabled = true;
            this.cmbEducation.Location = new System.Drawing.Point(199, 189);
            this.cmbEducation.Name = "cmbEducation";
            this.cmbEducation.Size = new System.Drawing.Size(154, 24);
            this.cmbEducation.TabIndex = 13;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(199, 129);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(154, 22);
            this.txtLastName.TabIndex = 12;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(199, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(154, 22);
            this.txtFirstName.TabIndex = 11;
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Location = new System.Drawing.Point(73, 198);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(87, 16);
            this.lblEducation.TabIndex = 10;
            this.lblEducation.Text = "Obrazovanje:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(73, 136);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 16);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Prezime:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(73, 74);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(32, 16);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "Ime:";
            // 
            // FrmCoachDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteCoach);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbEducation);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "FrmCoachDetails";
            this.Text = "FrmCoachDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCoach;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbEducation;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
    }
}