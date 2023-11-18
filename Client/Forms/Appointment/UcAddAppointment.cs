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

namespace Client.Forms.Term
{
    public partial class UcAddAppointment : UserControl
    {
        public UcAddAppointment()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void FillComboBox()
        {
            cmbCoach.DataSource = ClientController.Instance.GetAllCoaches();
            cmbCoach.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGroupName.Text == "" || txtNumOfApp.Text == "" || txtTime.Text == "" || cmbCoach.SelectedIndex == -1)
                {
                    MessageBox.Show("Morate popuniti sva polja!\nSistem ne može da kreira novi termin!");
                    return;
                }
                Group group = new Group();
                group.GroupName = txtGroupName.Text;
                group.Coach = (Domain.Coach)cmbCoach.SelectedItem;

                Domain.Appointment appointment = new Domain.Appointment();
                appointment.NumberOfAppointments = Int32.Parse(txtNumOfApp.Text);
                appointment.Time = Int32.Parse(txtTime.Text);
                appointment.Group = group;
                
                if (ClientController.Instance.CreateAppointment(appointment, group))
                {
                    MessageBox.Show("Sistem je kreirao novi termin!");
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Sistem ne može da kreira novi termin!");
                }
            }
            catch
            {
                MessageBox.Show("Sistem ne može da kreira novi termin!");
            }
            

        }
    }
}
