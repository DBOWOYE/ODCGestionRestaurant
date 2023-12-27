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
    public partial class FrmTable : Form
    {
        
        public FrmTable()
        {
            InitializeComponent();
        }

        private void BtnAddTable_Click(object sender, EventArgs e)
        {
            FrmNewTable table = new FrmNewTable();
            table.ShowDialog();
        }

        private void FrmTable_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            string qry = "Select * from tables";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvNom);
            lb.Items.Add(dgvPlaces);
            lb.Items.Add(dgvDispo);

            Table table = new Table();
            table.ChargementDonnees(qry, DataGridViewCategorie, lb);
        }

        private void DataGridViewCategorie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewCategorie.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(DataGridViewCategorie.CurrentRow.Cells["dgvid"].Value);

                    Table table = new Table();
                    table.Delete(id);
                    this.loadData();

                }


            }
            else if (DataGridViewCategorie.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                FrmNewTable frm = new FrmNewTable();
                frm.id = Convert.ToInt32(DataGridViewCategorie.CurrentRow.Cells["dgvid"].Value);
                frm.tbTableNom.Text = Convert.ToString(DataGridViewCategorie.CurrentRow.Cells["dgvNom"].Value);
                frm.tbTablePlace.Text = Convert.ToString(DataGridViewCategorie.CurrentRow.Cells["dgvPlaces"].Value);
                frm.BtnEnregistrerTable.Text = "Mettre à jour";
                frm.BtnEnregistrerTable.FillColor = Color.DarkBlue;
                frm.StartPosition = FormStartPosition.CenterScreen;
                

                frm.Show();
            }
        }


        
        private void BtnLibererTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DataGridViewCategorie.CurrentRow.Cells["dgvid"].Value);
            Table table = new Table();
            table.LibererTable(id);
            loadData();
        }

        private void tbRechercheTable_TextChanged(object sender, EventArgs e)
        {

            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvNom);
            Table table = new Table();
            table.DonneesRechercher(DataGridViewCategorie, lb, tbRechercheTable.Text.Trim());
        }
    }
}
