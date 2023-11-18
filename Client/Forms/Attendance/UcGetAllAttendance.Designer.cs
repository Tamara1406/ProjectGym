namespace Client.Forms.Attendance
{
    partial class UcGetAllAttendance
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
            this.dgvGetAllAttendance = new System.Windows.Forms.DataGridView();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblGroup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGetAllAttendance
            // 
            this.dgvGetAllAttendance.AllowUserToAddRows = false;
            this.dgvGetAllAttendance.AllowUserToDeleteRows = false;
            this.dgvGetAllAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetAllAttendance.Location = new System.Drawing.Point(53, 133);
            this.dgvGetAllAttendance.Name = "dgvGetAllAttendance";
            this.dgvGetAllAttendance.ReadOnly = true;
            this.dgvGetAllAttendance.RowHeadersWidth = 51;
            this.dgvGetAllAttendance.RowTemplate.Height = 24;
            this.dgvGetAllAttendance.Size = new System.Drawing.Size(564, 276);
            this.dgvGetAllAttendance.TabIndex = 16;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClient.Location = new System.Drawing.Point(436, 74);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(135, 37);
            this.btnSearchClient.TabIndex = 19;
            this.btnSearchClient.Text = "Prikazi prisustva";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            // 
            // cmbClient
            // 
            this.cmbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(210, 78);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(167, 30);
            this.cmbClient.TabIndex = 18;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(49, 78);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(140, 24);
            this.lblGroup.TabIndex = 17;
            this.lblGroup.Text = "Pretrazi klijente:";
            // 
            // UcGetAllAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearchClient);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.dgvGetAllAttendance);
            this.Name = "UcGetAllAttendance";
            this.Size = new System.Drawing.Size(691, 524);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGetAllAttendance;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblGroup;
    }
}
