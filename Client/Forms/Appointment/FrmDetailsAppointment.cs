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
    public partial class FrmDetailsAppointment : Form
    {
        Appointment appointment;
        public FrmDetailsAppointment(Appointment appointment)
        {
            try 
            {
                InitializeComponent();
                this.appointment = appointment;
                FillFields();
                MessageBox.Show("Sistem je učitao termin!");
            }
            catch
            {
                MessageBox.Show("Sistem ne može da učita termin!");
            }


        }

        private void FillFields()
        {
            txtTime.Text = appointment.Time.ToString();
            txtNumOfApp.Text = appointment.NumberOfAppointments.ToString();
            txtGroupName.Text = appointment.Group.GroupName;
            cmbCoach.DataSource = ClientController.Instance.GetAllCoaches();
            cmbCoach.Text = appointment.Group.Coach.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text == "" || txtNumOfApp.Text == "" || txtTime.Text == "" || cmbCoach.SelectedIndex == -1)
            {
                MessageBox.Show("Morate popuniti sva polja!\nSistem ne može da kreira novi termin!");
                return;
            }
            appointment.Time = Int32.Parse(txtTime.Text);
            appointment.NumberOfAppointments = Int32.Parse(txtNumOfApp.Text);
            appointment.Group.GroupName = txtGroupName.Text;
            appointment.Group.Coach = (Domain.Coach)cmbCoach.SelectedItem;


            if (ClientController.Instance.UpdateAppointment(appointment))
            {
                MessageBox.Show("Sistem je zapamtio termin!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sistem ne može da zapamti zapamti termin!");
            }
        }
    }
}
