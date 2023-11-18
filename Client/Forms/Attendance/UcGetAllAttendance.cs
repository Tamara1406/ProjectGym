using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.Attendance
{
    public partial class UcGetAllAttendance : UserControl
    {
        public UcGetAllAttendance()
        {
            InitializeComponent();
            FillComboBox();
            GetAllAttendance();
        }

        private void FillComboBox()
        {
            cmbClient.DataSource = ClientController.Instance.GetAllClients();
            cmbClient.SelectedIndex = -1;
        }
        public void GetAllAttendance()
        {
            dgvGetAllAttendance.DataSource = ClientController.Instance.GetAllAttendances();
        }
    }
}
