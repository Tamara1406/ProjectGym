namespace Client.Forms.Term
{
    partial class UcGetAllAppointment
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
            this.btnDeleteApp = new System.Windows.Forms.Button();
            this.btnSearchApp = new System.Windows.Forms.Button();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.lblSearchTerm = new System.Windows.Forms.Label();
            this.dgvGetAllApp = new System.Windows.Forms.DataGridView();
            this.btnUpdateApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllApp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteApp
            // 
            this.btnDeleteApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteApp.Location = new System.Drawing.Point(452, 423);
            this.btnDeleteApp.Name = "btnDeleteApp";
            this.btnDeleteApp.Size = new System.Drawing.Size(123, 36);
            this.btnDeleteApp.TabIndex = 13;
            this.btnDeleteApp.Text = "Obriši termin";
            this.btnDeleteApp.UseVisualStyleBackColor = true;
            this.btnDeleteApp.Click += new System.EventHandler(this.btnDeleteApp_Click);
            // 
            // btnSearchApp
            // 
            this.btnSearchApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchApp.Location = new System.Drawing.Point(360, 54);
            this.btnSearchApp.Name = "btnSearchApp";
            this.btnSearchApp.Size = new System.Drawing.Size(95, 32);
            this.btnSearchApp.TabIndex = 10;
            this.btnSearchApp.Text = "Pretraži";
            this.btnSearchApp.UseVisualStyleBackColor = true;
            this.btnSearchApp.Click += new System.EventHandler(this.btnSearchApp_Click);
            // 
            // cmbGroup
            // 
            this.cmbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(194, 56);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(131, 30);
            this.cmbGroup.TabIndex = 9;
            // 
            // lblSearchTerm
            // 
            this.lblSearchTerm.AutoSize = true;
            this.lblSearchTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTerm.Location = new System.Drawing.Point(54, 59);
            this.lblSearchTerm.Name = "lblSearchTerm";
            this.lblSearchTerm.Size = new System.Drawing.Size(134, 24);
            this.lblSearchTerm.TabIndex = 8;
            this.lblSearchTerm.Text = "Pretraži termin:";
            // 
            // dgvGetAllApp
            // 
            this.dgvGetAllApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetAllApp.Location = new System.Drawing.Point(48, 105);
            this.dgvGetAllApp.Name = "dgvGetAllApp";
            this.dgvGetAllApp.RowHeadersWidth = 51;
            this.dgvGetAllApp.RowTemplate.Height = 24;
            this.dgvGetAllApp.Size = new System.Drawing.Size(540, 295);
            this.dgvGetAllApp.TabIndex = 7;
            // 
            // btnUpdateApp
            // 
            this.btnUpdateApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateApp.Location = new System.Drawing.Point(301, 423);
            this.btnUpdateApp.Name = "btnUpdateApp";
            this.btnUpdateApp.Size = new System.Drawing.Size(123, 36);
            this.btnUpdateApp.TabIndex = 14;
            this.btnUpdateApp.Text = "Ažuriraj termin";
            this.btnUpdateApp.UseVisualStyleBackColor = true;
            this.btnUpdateApp.Click += new System.EventHandler(this.btnUpdateApp_Click);
            // 
            // UcGetAllAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdateApp);
            this.Controls.Add(this.btnDeleteApp);
            this.Controls.Add(this.btnSearchApp);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.lblSearchTerm);
            this.Controls.Add(this.dgvGetAllApp);
            this.Name = "UcGetAllAppointment";
            this.Size = new System.Drawing.Size(668, 497);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteApp;
        private System.Windows.Forms.Button btnSearchApp;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label lblSearchTerm;
        private System.Windows.Forms.DataGridView dgvGetAllApp;
        private System.Windows.Forms.Button btnUpdateApp;
    }
}
