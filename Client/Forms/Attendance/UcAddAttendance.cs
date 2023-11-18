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

namespace Client.Forms.Attendance
{
    public partial class UcAddAttendance : UserControl
    {
        public UcAddAttendance()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void FillComboBox()
        {
            cmbClient.DataSource = ClientController.Instance.GetAllClients();
            cmbClient.SelectedIndex = -1;
            cmbAppointment.DataSource = ClientController.Instance.GetAllAppointments();
            cmbAppointment.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Domain.Attendance attendance = new Domain.Attendance();
            attendance.Client = (Domain.Client)cmbClient.SelectedItem;
            attendance.Appointment = (Domain.Appointment)cmbAppointment.SelectedItem;
            if (rbYes.Checked)
            {
                attendance.IsAttend = true;
            }
            else if (rbNo.Checked)
            {
                attendance.IsAttend = false;
            }

            if (ClientController.Instance.CreateAttendance(attendance))
            {
                MessageBox.Show("Prisustvo je zabeleženo!");
                Visible = false;
            }
            else
            {
                MessageBox.Show("Neuspešno zabeležavanje prisustva!");
            }
        }
    }
}
