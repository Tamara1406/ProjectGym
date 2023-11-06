using System;
using Domain;
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
    public partial class FrmCoachDetails : Form
    {
        Domain.Coach coach;
        public FrmCoachDetails(Domain.Coach coach)
        {
            InitializeComponent();
            this.coach = coach;
            FillFields();
        }


        public void FillFields()
        {
            txtFirstName.Text = coach.FirstName;
            txtLastName.Text = coach.LastName;
            cmbEducation.DataSource = ClientController.Instance.GetAllEducations();
            cmbEducation.SelectedIndex = coach.Education.EducationID - 1;
        }

        private void btnDeleteCoach_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Obriši trenera {coach.Name}?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            List<Group> groups = ClientController.Instance.GetAllGroups();
            if (result == DialogResult.Yes)
            {
                foreach(Group group in groups)
                {
                    if(group.Coach.CoachID == coach.CoachID)
                    {
                        MessageBox.Show("Nije moguće obrisati trenera koji ima grupu vežbača!");
                        return;
                    }
                }
                ClientController.Instance.DeleteCoach(coach);
                this.Close();
                MessageBox.Show("Trener je obrisan!");
            }
            
            
            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            coach.FirstName = txtFirstName.Text;
            coach.LastName = txtLastName.Text;
            coach.Education = (Education) cmbEducation.SelectedItem;


            if (ClientController.Instance.UpdateCoach(coach))
            {
                MessageBox.Show("Sačuvane su izmene na treneru!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nije moguće sačuvati izmene!");
            }
        }
    }
}
