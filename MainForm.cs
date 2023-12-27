using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionRestaurant.Views;

namespace GestionRestaurant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (Utilisateur.ROLE != "Admin")
            {
                btnUser.Hide();
            }
        }

        public void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
             lbUser.Text = Utilisateur.USER;
            lbRole.Text = Utilisateur.ROLE;
            AddControls(new FrmMenu());
            BtnMenu.Checked = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void onClick_btnUser(object sender, EventArgs e)
        {
            AddControls(new FrmUtilisateur());
        }
        private void SeDeconnecter_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            MainForm mainForm = this;

            mainForm.Close();
            Utilisateur.USER = "";
            Utilisateur.ROLE = "";

        }

        private void BtnCategorie_Click(object sender, EventArgs e)
        {
            AddControls(new FrmCategorie());
        }

        private void BtnPlat_Click(object sender, EventArgs e)
        {
            AddControls(new FrmProduits());
        }

        private void BtnCommande_Click(object sender, EventArgs e)
        {
            AddControls(new FrmCommande());
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            AddControls(new FrmMenu());
        }

        private void BtnReservation_Click(object sender, EventArgs e)
        {
            AddControls(new FrmReservation());
        }

        private void BtnTable_Click(object sender, EventArgs e)
        {
            AddControls(new FrmTable());
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            AddControls(new FrmClient());
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            FrmPwdUpdate frm = new FrmPwdUpdate();
            frm.ShowDialog();
        }

        private void btnIngredient_Click(object sender, EventArgs e)
        {
            AddControls(new FrmIngredients());
        }
    }
}
