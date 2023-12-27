using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionRestaurant.Views
{
    public partial class FrmPwdUpdate : Form
    {
        public int id = 0;
        public FrmPwdUpdate()
        {
            InitializeComponent();
        }

        private void BtnFermerPwd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEnregistrerPwd_Click(object sender, EventArgs e)
        {
            if(tbPass.Text.Trim().Length > 0)
            {
                int id = Utilisateur.ID;
                string pass = Utilisateur.HashPassword(tbPass.Text.Trim());

                Utilisateur user = new Utilisateur();
                user.ChangePassword(pass, id);
                this.Close();

            }
        }

        private void FrmPwdUpdate_Load(object sender, EventArgs e)
        {
            
        }
    }
}
