using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionRestaurant.Model;
using GestionRestaurant.Views;

namespace GestionRestaurant
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            FrmAddClient frm = new FrmAddClient();
            frm.ShowDialog();
        }
        public void loadData()
        {
            string qry = "Select * from clients";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvNom);
            lb.Items.Add(dgvPrenom);
            lb.Items.Add(dgvtel);
            lb.Items.Add(dgvadress);
            lb.Items.Add(dgvGenre);
            
            Client clt = new Client();
            clt.ChargementDonnees(qry, DataGridViewClient, lb);
        }
        
        private void FrmClient_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void DataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewClient.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(DataGridViewClient.CurrentRow.Cells["dgvid"].Value);

                    Client clt = new Client();
                    clt.Delete(id);
                    this.loadData();

                }


            }
            else if (DataGridViewClient.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                FrmAddClient frm = new FrmAddClient();
                frm.id = Convert.ToInt32(DataGridViewClient.CurrentRow.Cells["dgvid"].Value);
                frm.tbNom.Text = Convert.ToString(DataGridViewClient.CurrentRow.Cells["dgvNom"].Value);
                frm.tbPrenom.Text = Convert.ToString(DataGridViewClient.CurrentRow.Cells["dgvPrenom"].Value);
                frm.tbTel.Text = Convert.ToString(DataGridViewClient.CurrentRow.Cells["dgvtel"].Value);
                frm.tbAdress.Text = Convert.ToString(DataGridViewClient.CurrentRow.Cells["dgvadress"].Value);
                frm.comboGenre.Text = Convert.ToString(DataGridViewClient.CurrentRow.Cells["dgvGenre"].Value);

                frm.btnEnregistrer.Text = "Mettre à jour";
                frm.btnEnregistrer.FillColor = Color.DarkBlue;
                frm.StartPosition = FormStartPosition.CenterScreen;

                frm.Show();
            }

        }


        private void tbRechercheClient_TextChanged(object sender, EventArgs e)
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvNom);
            lb.Items.Add(dgvPrenom);
            lb.Items.Add(dgvtel);
            lb.Items.Add(dgvadress);
            lb.Items.Add(dgvGenre);
            Client clt = new Client();
            clt.DonneesRechercher(DataGridViewClient, lb, tbRechercheClient.Text.Trim());
        }
    }
}
