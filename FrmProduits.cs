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
    public partial class FrmProduits : Form
    {
        public FrmProduits()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddProduit frm = new FrmAddProduit();
            frm.ShowDialog();
        }

        public void loadData()
        {
            string qry = "Select p.id, p.designation, p.prix, p.description,c.nom, p.photo from produits as p JOIN categories as c ON p.idCategorie = c.id";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvNom);
            lb.Items.Add(dgvPrix);
            lb.Items.Add(dgvDescription);
            lb.Items.Add(dgvCategorie);
            lb.Items.Add(dgvImage);

            Produit clt = new Produit();
            clt.ChargementDonnees(qry, DataGridViewClient, lb);
        }

        private void FrmProduits_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
