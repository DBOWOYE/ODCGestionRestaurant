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
    public partial class FrmCategorie : Form
    {
        public FrmCategorie()
        {
            InitializeComponent();
        }

        private void BtnAddCategorie_Click(object sender, EventArgs e)
        {
            FrmNewCategorie frm = new FrmNewCategorie();
            frm.ShowDialog();
        }

        private void FrmCategorie_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            string qry = "Select * from categories";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvNom);
            
            Categorie cat = new Categorie();
            cat.ChargementDonnees(qry, DataGridViewCategorie, lb);
        }

        private void DataGridViewCategorie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewCategorie.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(DataGridViewCategorie.CurrentRow.Cells["dgvid"].Value);

                    Categorie cat = new Categorie();
                    cat.Delete( id);
                    this.loadData();

                }


            }
            else if (DataGridViewCategorie.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                FrmAddIngredient frm = new FrmAddIngredient();
                frm.id = Convert.ToInt32(DataGridViewCategorie.CurrentRow.Cells["dgvid"].Value);
                frm.tbIngredient.Text = Convert.ToString(DataGridViewCategorie.CurrentRow.Cells["dgvNom"].Value);
                frm.BtnEnregistrer.Text = "Mettre à jour";
                frm.BtnEnregistrer.FillColor = Color.DarkBlue;
                frm.StartPosition = FormStartPosition.CenterScreen;

                frm.Show();
            }
        }

        private void tbRechercheUser_TextChanged(object sender, EventArgs e)
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvNom);
            Categorie cat = new Categorie();
            cat.DonneesRechercher(DataGridViewCategorie, lb, tbRechercheUser.Text.Trim());
        }
    }
}
