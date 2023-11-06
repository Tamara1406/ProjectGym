namespace Client.Forms.Coach
{
    partial class UcGetAllCoach
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnEducation = new System.Windows.Forms.Button();
            this.cmbEducation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvGetAllCoach = new System.Windows.Forms.DataGridView();
            this.btnName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllCoach)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(320, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 22);
            this.txtName.TabIndex = 25;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(587, 409);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(120, 38);
            this.btnDetails.TabIndex = 24;
            this.btnDetails.Text = "Detalji";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnEducation
            // 
            this.btnEducation.Location = new System.Drawing.Point(520, 90);
            this.btnEducation.Name = "btnEducation";
            this.btnEducation.Size = new System.Drawing.Size(110, 29);
            this.btnEducation.TabIndex = 23;
            this.btnEducation.Text = "Prikazi trenere";
            this.btnEducation.UseVisualStyleBackColor = true;
            this.btnEducation.Click += new System.EventHandler(this.btnEducation_Click);
            // 
            // cmbEducation
            // 
            this.cmbEducation.FormattingEnabled = true;
            this.cmbEducation.Location = new System.Drawing.Point(320, 93);
            this.cmbEducation.Name = "cmbEducation";
            this.cmbEducation.Size = new System.Drawing.Size(172, 24);
            this.cmbEducation.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Pretrazi trenere prema obrazovanju:";
            // 
            // dgvGetAllCoach
            // 
            this.dgvGetAllCoach.AllowUserToAddRows = false;
            this.dgvGetAllCoach.AllowUserToDeleteRows = false;
            this.dgvGetAllCoach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetAllCoach.Location = new System.Drawing.Point(46, 141);
            this.dgvGetAllCoach.Name = "dgvGetAllCoach";
            this.dgvGetAllCoach.ReadOnly = true;
            this.dgvGetAllCoach.RowHeadersWidth = 51;
            this.dgvGetAllCoach.RowTemplate.Height = 24;
            this.dgvGetAllCoach.Size = new System.Drawing.Size(661, 246);
            this.dgvGetAllCoach.TabIndex = 20;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(520, 44);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(110, 29);
            this.btnName.TabIndex = 19;
            this.btnName.Text = "Nadji trenera";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pretrazi trenere prema imenu i prezimenu:";
            // 
            // UcGetAllCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnEducation);
            this.Controls.Add(this.cmbEducation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvGetAllCoach);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.label1);
            this.Name = "UcGetAllCoach";
            this.Size = new System.Drawing.Size(742, 505);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllCoach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnEducation;
        private System.Windows.Forms.ComboBox cmbEducation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvGetAllCoach;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Label label1;
    }
}
