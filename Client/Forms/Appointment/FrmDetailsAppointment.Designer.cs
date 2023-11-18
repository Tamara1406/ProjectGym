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
            this.cmbCoach = new System.Windows.Forms.ComboBox();
            this.lblCoach = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtNumOfApp = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblNumOfTerms = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCoach
            // 
            this.cmbCoach.FormattingEnabled = true;
            this.cmbCoach.Location = new System.Drawing.Point(259, 256);
            this.cmbCoach.Name = "cmbCoach";
            this.cmbCoach.Size = new System.Drawing.Size(135, 24);
            this.cmbCoach.TabIndex = 26;
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoach.Location = new System.Drawing.Point(83, 254);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(72, 24);
            this.lblCoach.TabIndex = 25;
            this.lblCoach.Text = "Trener:";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(259, 190);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(135, 22);
            this.txtGroupName.TabIndex = 24;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(180, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 45);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(259, 130);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(62, 22);
            this.txtTime.TabIndex = 22;
            // 
            // txtNumOfApp
            // 
            this.txtNumOfApp.Location = new System.Drawing.Point(259, 70);
            this.txtNumOfApp.Name = "txtNumOfApp";
            this.txtNumOfApp.Size = new System.Drawing.Size(135, 22);
            this.txtNumOfApp.TabIndex = 21;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupName.Location = new System.Drawing.Point(83, 188);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(116, 24);
            this.lblGroupName.TabIndex = 20;
            this.lblGroupName.Text = "Naziv grupe:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(83, 128);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(139, 24);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "Vreme termina:";
            // 
            // lblNumOfTerms
            // 
            this.lblNumOfTerms.AutoSize = true;
            this.lblNumOfTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfTerms.Location = new System.Drawing.Point(83, 68);
            this.lblNumOfTerms.Name = "lblNumOfTerms";
            this.lblNumOfTerms.Size = new System.Drawing.Size(115, 24);
            this.lblNumOfTerms.TabIndex = 18;
            this.lblNumOfTerms.Text = "Broj termina:";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(327, 128);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(21, 24);
            this.lblH.TabIndex = 27;
            this.lblH.Text = "h";
            // 
            // FrmDetailsAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 468);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.cmbCoach);
            this.Controls.Add(this.lblCoach);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtNumOfApp);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNumOfTerms);
            this.Name = "FrmDetailsAppointment";
            this.Text = "FrmDetailsTerm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCoach;
        private System.Windows.Forms.Label lblCoach;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtNumOfApp;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblNumOfTerms;
        private System.Windows.Forms.Label lblH;
    }
}