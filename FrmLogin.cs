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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text.Trim();
            string password = Utilisateur.HashPassword(tbPassword.Text.Trim());
            if (username.Length > 0 
                || password.Length > 0) {

                Utilisateur user  = new Utilisateur();
                
                if (user.IsValidUser(username.ToString(), password.ToString()) == true)
                {
                    if (Utilisateur.STATUS == "oui")
                    {
                        
                        this.Hide();
                        MainForm form = new MainForm();
                       // form.tbox.Text = Utilisateur.HashPassword(password);
                        form.Show();
                    }else
                    {
                        MessageBox.Show("Votre compte est desactivé !\n Veuillez contacter l'administrateur");
                    }
                    
                }

            }else
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
