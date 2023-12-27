using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionRestaurant
{
    public partial class FrmAddNewUser : Form
    {
        public int id = 0;
        FrmUtilisateur frm = new FrmUtilisateur();
        public FrmAddNewUser()
        {
            InitializeComponent();
        }
        private void ViderChamp()
        {
            tbNom.Text = string.Empty;
            tbAdress.Text = string.Empty;
            tbTel.Text = string.Empty;
            comboRole.Text = string.Empty;
            
        }
        private void btnEnregistrer_Click(object sender, EventArgs e){
            
            string nom = tbNom.Text.Trim();
            string tel = tbTel.Text.Trim();
            string adress = tbAdress.Text.Trim();
            string pass = Utilisateur.HashPassword("12345");
            string role = comboRole.Text.Trim();

            Utilisateur user = new Utilisateur();
            user.Nom = nom;
            user.Telephone = tel;
            user.Adresse = adress;
            user.Password = pass;
            user.Role = role;

            if (nom.Length > 0 && tel.Length > 0 && adress.Length > 0 && role.Length > 0)
            {
                if(id == 0)
                {
                    user.Insert(user.Nom, user.Telephone, user.Adresse, user.Password, user.Role); ;
                    ViderChamp();
                }
                else
                {
                    user.Update(user.Nom, user.Telephone, user.Adresse, user.Role, id);
                    ViderChamp();
                    this.Close();

                }

               
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void FrmAddNewUser_Load(object sender, EventArgs e)
        {
            Utilisateur utilisateur = new Utilisateur();
            utilisateur.ChargerCombo(comboRole);
        }
    }
}
