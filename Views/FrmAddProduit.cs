using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionRestaurant.Model;

namespace GestionRestaurant.Views
{
    public partial class FrmAddProduit : Form
    {
        public FrmAddProduit()
        {
            InitializeComponent();
        }
        string filePath;
        Produit p = new Produit();
        public int idCombo;
        private void btnImporterImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|* .png; *.jpg";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                tbImage.Image = new Bitmap(filePath);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddProduit_Load(object sender, EventArgs e)
        {
            p.ChargerCombo(comboCategorie);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string designation = tbNom.Text.Trim();
            string prix = tbPrix.Text.Trim();
            string description = tbDescription.Text.Trim();
            Image image = new Bitmap(filePath);

            MemoryStream ms = new MemoryStream();
            tbImage.Image.Save(ms, tbImage.Image.RawFormat);
            byte[] img = ms.ToArray();

            if(designation.Length == 0 ||  prix.Length == 0 || description.Length == 0) {
                MessageBox.Show("Veuillez remplir les champs du formulaire");
            }else
            {
                Produit prod = new Produit();
                prod.Designation = designation;
                prod.Prix = prix;
                prod.Description = description;
                
                prod.Categorie = idCombo;
                prod.Image = img;

                prod.Insert(prod);
            }
            
        }

        private void comboCategorie_Leave(object sender, EventArgs e)
        {
            string cb = comboCategorie.Text.Trim().ToString();
            Categorie categorie = new Categorie();

            idCombo = Convert.ToInt16(categorie.RecupererCategorie(cb)) ;
        }

        private void tbPrix_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbPrix_Leave(object sender, EventArgs e)
        {
            int val=0;
            if (!int.TryParse(tbPrix.Text, out val))
            {
                MessageBox.Show("Veuillez saisir le prix en chiffre !");
                tbPrix.Focus();
            }
                
        }
    }
}
