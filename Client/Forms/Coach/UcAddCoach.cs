using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.Coach
{
    public partial class UcAddCoach : UserControl
    {
        public UcAddCoach()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void FillComboBox()
        {
            cmbEducation.Items.Clear();
            cmbEducation.DataSource = ClientController.Instance.GetAllEducations();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Domain.Coach coach = new Domain.Coach();
            coach.FirstName = txtFirstName.Text;
            coach.LastName = txtLastName.Text;
            coach.Education = (Domain.Education)cmbEducation.SelectedItem;

            if (ClientController.Instance.CreateCoach(coach))
            {
                MessageBox.Show("Novi trener je kreiran!");
                Visible = false;
            }
            else
            {
                MessageBox.Show("Neuspešno kreiranje trenera!");
            }
        }
    }
}
