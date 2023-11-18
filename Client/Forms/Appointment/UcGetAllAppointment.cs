using Domain;
using System;
using Client.Forms.Coach;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Client.Forms.Term
{
    public partial class UcGetAllAppointment : UserControl
    {
        public UcGetAllAppointment()
        {
            InitializeComponent();
            FillComboBox();
            GetAllAppointments();
        }

        private void FillComboBox()
        {
            cmbGroup.DataSource = ClientController.Instance.GetAllGroups();
            cmbGroup.SelectedIndex = -1;
        }

        public void GetAllAppointments()
        {
            dgvGetAllApp.DataSource = ClientController.Instance.GetAllAppointments();
        }

        private void btnSearchApp_Click(object sender, EventArgs e)
        {
            try
            {
                Group group = cmbGroup.SelectedItem as Group;
                if(cmbGroup.SelectedIndex == -1)
                {
                    MessageBox.Show("Morate izabrati vrednost!\nSistem ne može da nađe termine po zadatoj vrednosti!");
                    return;
                }
                dgvGetAllApp.DataSource = null;
                dgvGetAllApp.DataSource = ClientController.Instance.GetAllAppointmentsByGroup(group);
                if (dgvGetAllApp.RowCount == 0)
                {
                    MessageBox.Show("Ne postoji termin za tu grupu! \n Sistem ne može da nadje termin po zadatoj vrednosti.");
                    cmbGroup.SelectedIndex = -1;
                    return;
                }
                MessageBox.Show("Sistem je našao termine po zadatoj vrednosti!");
            }
            catch
            {
                MessageBox.Show("Sistem ne može da nađe termine po zadatoj vrednosti!");
            }
            
        }

        private void btnDeleteApp_Click(object sender, EventArgs e)
        {
            Appointment appointment = (Appointment)dgvGetAllApp.SelectedRows[0].DataBoundItem;
            DialogResult result = MessageBox.Show($"Obriši termin u {appointment.Time} grupe {appointment.Group.GroupName}?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            ClientController.Instance.DeleteAppointment(appointment);
            MessageBox.Show("Termin je obrisan!");
        }

        private void btnUpdateApp_Click(object sender, EventArgs e)
        {
            try { 
                Appointment appointment = (Appointment)dgvGetAllApp.SelectedRows[0].DataBoundItem;
                FrmDetailsAppointment frm = new FrmDetailsAppointment(appointment);
                frm.ShowDialog();
                dgvGetAllApp.DataSource = ClientController.Instance.GetAllAppointments();
            }
            catch
            {
                MessageBox.Show("Morate označiti ceo red!\nSistem ne može da učita termin!");
            }
}
    }
}
