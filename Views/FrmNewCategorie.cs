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

namespace GestionRestaurant.Views
{
    public partial class FrmNewCategorie : Form
    {
        public int id = 0;
        public FrmNewCategorie()
        {
            InitializeComponent();
        }

        private void BtnFermerCategorie_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        
        private void BtnEnregistrerCategorie_Click(object sender, EventArgs e)
        {
            string categorie = tbCategorieNom.Text.Trim();
            
            if (categorie.Length == 0 )
            {
                MessageBox.Show("Veuillez remplir le champ Catégorie !");
                tbCategorieNom.Focus();
            }else
            {
                Categorie cat = new Categorie();
                cat.Nom = categorie;
                if (id == 0)
                {
                    cat.Insert(cat.Nom);
                    
                }else
                {
                    cat.Update(cat.Nom, id);
                }
                

                tbCategorieNom.Text = "";
            }

            FrmCategorie frm = new FrmCategorie();
            frm.loadData();
        }

        private void FrmNewCategorie_Load(object sender, EventArgs e)
        {

        }
    }
}
