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
    public partial class UcGetAllClients : UserControl
    {
        public UcGetAllClients()
        {
            InitializeComponent();
            GetAllClients();
            FillComboBox();
        }

        public void GetAllClients()
        {
            dgvGetAllClients.DataSource = ClientController.Instance.GetAllClients();
        }


        public void FillComboBox()
        {
            cmbGroup.DataSource = ClientController.Instance.GetAllGroups();
            cmbGroup.SelectedIndex = -1;
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string searchStr = txtName.Text;
            dgvGetAllClients.DataSource = null;
            dgvGetAllClients.DataSource = ClientController.Instance.GetClientSearchedByName(searchStr);
            dgvGetAllClients.ClearSelection();
            if (dgvGetAllClients.RowCount == 0)
            {
                MessageBox.Show("Ne postoji klijent sa tim imenom!");
            }
            txtName.Text = "";
        }

        private void btnSearchGroup_Click(object sender, EventArgs e)
        {
            Group group = (Group)cmbGroup.SelectedItem;
            cmbGroup.SelectedIndex = -1;
            dgvGetAllClients.DataSource = null;
            dgvGetAllClients.DataSource = ClientController.Instance.GetAllClientsByGroup(group);
        }

        private void btnDetailsClient_Click(object sender, EventArgs e)
        {
            try
            {
                Domain.Client client = (Domain.Client)dgvGetAllClients.SelectedRows[0].DataBoundItem;
                FrmClientDetails frm = new FrmClientDetails(client);
                frm.ShowDialog();
                dgvGetAllClients.DataSource = ClientController.Instance.GetAllClients();
            }
            catch
            {
                MessageBox.Show("Morate označiti ceo red!");
            }

        }
    }
}
