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
            this.btnDeleteTerm = new System.Windows.Forms.Button();
            this.btnAddTerm = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnSearchTerm = new System.Windows.Forms.Button();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.lblSearchTerm = new System.Windows.Forms.Label();
            this.dgwGetAllTerms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGetAllTerms)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteTerm
            // 
            this.btnDeleteTerm.Location = new System.Drawing.Point(452, 423);
            this.btnDeleteTerm.Name = "btnDeleteTerm";
            this.btnDeleteTerm.Size = new System.Drawing.Size(123, 36);
            this.btnDeleteTerm.TabIndex = 13;
            this.btnDeleteTerm.Text = "Obriši termin";
            this.btnDeleteTerm.UseVisualStyleBackColor = true;
            // 
            // btnAddTerm
            // 
            this.btnAddTerm.Location = new System.Drawing.Point(452, 474);
            this.btnAddTerm.Name = "btnAddTerm";
            this.btnAddTerm.Size = new System.Drawing.Size(123, 36);
            this.btnAddTerm.TabIndex = 12;
            this.btnAddTerm.Text = "Kreiraj termin";
            this.btnAddTerm.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(301, 423);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(123, 36);
            this.btnDetails.TabIndex = 11;
            this.btnDetails.Text = "Detalji";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnSearchTerm
            // 
            this.btnSearchTerm.Location = new System.Drawing.Point(329, 51);
            this.btnSearchTerm.Name = "btnSearchTerm";
            this.btnSearchTerm.Size = new System.Drawing.Size(95, 32);
            this.btnSearchTerm.TabIndex = 10;
            this.btnSearchTerm.Text = "Pretraži";
            this.btnSearchTerm.UseVisualStyleBackColor = true;
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(166, 56);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(131, 24);
            this.cmbGroup.TabIndex = 9;
            // 
            // lblSearchTerm
            // 
            this.lblSearchTerm.AutoSize = true;
            this.lblSearchTerm.Location = new System.Drawing.Point(54, 59);
            this.lblSearchTerm.Name = "lblSearchTerm";
            this.lblSearchTerm.Size = new System.Drawing.Size(94, 16);
            this.lblSearchTerm.TabIndex = 8;
            this.lblSearchTerm.Text = "Pretraži termin:";
            // 
            // dgwGetAllTerms
            // 
            this.dgwGetAllTerms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGetAllTerms.Location = new System.Drawing.Point(48, 105);
            this.dgwGetAllTerms.Name = "dgwGetAllTerms";
            this.dgwGetAllTerms.RowHeadersWidth = 51;
            this.dgwGetAllTerms.RowTemplate.Height = 24;
            this.dgwGetAllTerms.Size = new System.Drawing.Size(540, 295);
            this.dgwGetAllTerms.TabIndex = 7;
            // 
            // UcGetAllTerms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteTerm);
            this.Controls.Add(this.btnAddTerm);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnSearchTerm);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.lblSearchTerm);
            this.Controls.Add(this.dgwGetAllTerms);
            this.Name = "UcGetAllTerms";
            this.Size = new System.Drawing.Size(668, 532);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGetAllTerms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteTerm;
        private System.Windows.Forms.Button btnAddTerm;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnSearchTerm;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label lblSearchTerm;
        private System.Windows.Forms.DataGridView dgwGetAllTerms;
    }
}
