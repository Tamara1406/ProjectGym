using Client.Forms.Coach;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FrmMain : Form
    {
        User user;
        UcGetAllCoach ucGetAllCoach;
        UcAddCoach ucAddCoach;
        public FrmMain(User user)
        {
            InitializeComponent();
            this.user = ClientController.Instance.GetUserByUsername(user);
            user = ClientController.Instance.GetUserByUsername(user);

        }

        private void tsmiGetAllCoach_Click(object sender, EventArgs e)
        {
            ucGetAllCoach = new UcGetAllCoach();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucGetAllCoach);
        }

        private void tsmiAddCoach_Click(object sender, EventArgs e)
        {
            ucAddCoach = new UcAddCoach();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucAddCoach);

        }
    }
}
