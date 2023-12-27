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
    public partial class FrmAddClient : Form
    {
        public int id = 0;
        public FrmAddClient()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ViderForm()
        {
            tbNom.Text = "";
            tbPrenom.Text = "";
           tbTel.Text = "";
           tbAdress.Text ="";
           comboGenre.Text = "";
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string nom = tbNom.Text.Trim().ToUpper();
            string prenom = tbPrenom.Text.Trim();
            string telephone = tbTel.Text.Trim();
            string adresse = tbAdress.Text.Trim();
            string genre = comboGenre.Text.Trim();
            
            int tel;
            if (nom.Length == 0 || prenom.Length == 0 || adresse.Length == 0 || genre.Length == 0 || telephone.Length == 0)
            {

                MessageBox.Show("Veuillez remplir tous les champs obligatoires !");
            }
            else if(!int.TryParse(telephone, out tel) || telephone.Length != 9)
            {
                MessageBox.Show("Le numéro de telephone est incorrect !");
                tbTel.Focus();
            }else
            {


                Client clt = new Client();
                clt.Nom = nom;
                clt.Prenom = prenom;
                clt.Telephone = telephone;
                clt.Adresse = adresse;
                clt.Genre = genre;
                clt.Telephone = telephone;

                if(id == 0)
                {
                    clt.Insert(clt);

                }else
                {
                    clt.Update(clt, id);
                }
                FrmClient frm = new FrmClient();
                frm.loadData();


            }
        }
    }
}
