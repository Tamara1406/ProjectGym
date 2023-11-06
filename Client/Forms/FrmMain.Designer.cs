namespace Client.Forms
{
    partial class FrmMain
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.treneriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetAllCoach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddCoach = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetAllClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddClient = new System.Windows.Forms.ToolStripMenuItem();
            this.grupeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetAllGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.terminiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetAllAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(12, 63);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(922, 495);
            this.pnlMain.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treneriToolStripMenuItem,
            this.klijentiToolStripMenuItem,
            this.grupeToolStripMenuItem,
            this.terminiToolStripMenuItem,
            this.tsmiLogin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // treneriToolStripMenuItem
            // 
            this.treneriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGetAllCoach,
            this.tsmiAddCoach});
            this.treneriToolStripMenuItem.Name = "treneriToolStripMenuItem";
            this.treneriToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.treneriToolStripMenuItem.Text = "Treneri";
            // 
            // tsmiGetAllCoach
            // 
            this.tsmiGetAllCoach.Name = "tsmiGetAllCoach";
            this.tsmiGetAllCoach.Size = new System.Drawing.Size(224, 26);
            this.tsmiGetAllCoach.Text = "Prikaži trenere";
            this.tsmiGetAllCoach.Click += new System.EventHandler(this.tsmiGetAllCoach_Click);
            // 
            // tsmiAddCoach
            // 
            this.tsmiAddCoach.Name = "tsmiAddCoach";
            this.tsmiAddCoach.Size = new System.Drawing.Size(224, 26);
            this.tsmiAddCoach.Text = "Dodaj trenera";
            this.tsmiAddCoach.Click += new System.EventHandler(this.tsmiAddCoach_Click);
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGetAllClient,
            this.tsmiAddClient});
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.klijentiToolStripMenuItem.Text = "Klijenti";
            // 
            // tsmiGetAllClient
            // 
            this.tsmiGetAllClient.Name = "tsmiGetAllClient";
            this.tsmiGetAllClient.Size = new System.Drawing.Size(187, 26);
            this.tsmiGetAllClient.Text = "Prikaži klijente";
            // 
            // tsmiAddClient
            // 
            this.tsmiAddClient.Name = "tsmiAddClient";
            this.tsmiAddClient.Size = new System.Drawing.Size(187, 26);
            this.tsmiAddClient.Text = "Dodaj klijenta";
            // 
            // grupeToolStripMenuItem
            // 
            this.grupeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGetAllGroup,
            this.tsmiAddGroup});
            this.grupeToolStripMenuItem.Name = "grupeToolStripMenuItem";
            this.grupeToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.grupeToolStripMenuItem.Text = "Grupe";
            // 
            // tsmiGetAllGroup
            // 
            this.tsmiGetAllGroup.Name = "tsmiGetAllGroup";
            this.tsmiGetAllGroup.Size = new System.Drawing.Size(178, 26);
            this.tsmiGetAllGroup.Text = "Prikaži grupe";
            // 
            // tsmiAddGroup
            // 
            this.tsmiAddGroup.Name = "tsmiAddGroup";
            this.tsmiAddGroup.Size = new System.Drawing.Size(178, 26);
            this.tsmiAddGroup.Text = "Dodaj grupu";
            // 
            // terminiToolStripMenuItem
            // 
            this.terminiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGetAllAppointment});
            this.terminiToolStripMenuItem.Name = "terminiToolStripMenuItem";
            this.terminiToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.terminiToolStripMenuItem.Text = "Termini";
            // 
            // tsmiGetAllAppointment
            // 
            this.tsmiGetAllAppointment.Name = "tsmiGetAllAppointment";
            this.tsmiGetAllAppointment.Size = new System.Drawing.Size(190, 26);
            this.tsmiGetAllAppointment.Text = "Tabela termina";
            // 
            // tsmiLogin
            // 
            this.tsmiLogin.Name = "tsmiLogin";
            this.tsmiLogin.Size = new System.Drawing.Size(67, 24);
            this.tsmiLogin.Text = "Prijava";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 570);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem treneriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetAllCoach;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddCoach;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetAllClient;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddClient;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetAllGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetAllAppointment;
    }
}