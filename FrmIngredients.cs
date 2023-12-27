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
    public partial class FrmIngredients : Form
    {
        public FrmIngredients()
        {
            InitializeComponent();
        }

        private void BtnAddIngredient_Click(object sender, EventArgs e)
        {
            FrmAddIngredient frm = new FrmAddIngredient(); 
            frm.ShowDialog();
        }

        public void loadData()
        {
            string qry = "Select * from ingredients";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvIngredient);

            Ingredient ing = new Ingredient();
            ing.ChargementDonnees(qry, DataGridViewCategorie, lb);
        }


        private void DataGridViewCategorie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewCategorie.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(DataGridViewCategorie.CurrentRow.Cells["dgvid"].Value);

                    Ingredient ing = new Ingredient();
                    ing.Delete(id);
                    this.loadData();

                }


            }
            else if (DataGridViewCategorie.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                FrmAddIngredient frm = new FrmAddIngredient();
                frm.id = Convert.ToInt32(DataGridViewCategorie.CurrentRow.Cells["dgvid"].Value);
                frm.tbIngredient.Text = Convert.ToString(DataGridViewCategorie.CurrentRow.Cells["dgvIngredient"].Value);
                frm.BtnEnregistrer.Text = "Mettre à jour";
                frm.BtnEnregistrer.FillColor = Color.DarkBlue;
                frm.StartPosition = FormStartPosition.CenterScreen;

                frm.Show();
            }
        }

        private void FrmIngredients_Load(object sender, EventArgs e)
        {
            loadData();
        }

        

        private void tbRechercher_TextChanged(object sender, EventArgs e)
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvIngredient);
            Ingredient ing = new Ingredient();
            ing.DonneesRechercher(DataGridViewCategorie, lb, tbRechercher.Text.Trim());
        }
    }
}
