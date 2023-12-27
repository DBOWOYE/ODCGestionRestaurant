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
using Guna.UI2.WinForms;

namespace GestionRestaurant
{
    public partial class FrmUtilisateur : Form
    {
        public FrmUtilisateur()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAddNewUser frm = new FrmAddNewUser();   
            frm.ShowDialog();
        }

        public void FrmUtilisateur_Load(object sender, EventArgs e)
        {
            loadData();


        }

       public void loadData()
        {
            string qry = "Select * from utilisateur";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvNom);
            lb.Items.Add(dgvtel);
            lb.Items.Add(dgvadress);
            lb.Items.Add(dgvpass);
            lb.Items.Add(dgvrole);
            lb.Items.Add(dgvActif);
            Utilisateur user = new Utilisateur();
            user.ChargementDonnees(qry, DataGridViewUser, lb);
        }

        private void DataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(DataGridViewUser.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(DataGridViewUser.CurrentRow.Cells["dgvid"].Value);

                    Utilisateur user = new Utilisateur();
                        user.Delete("utilisateur", id);
                    
                    
                }
                
                
            }else if (DataGridViewUser.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                FrmAddNewUser frm = new FrmAddNewUser();
                frm.id = Convert.ToInt32(DataGridViewUser.CurrentRow.Cells["dgvid"].Value);
                frm.tbNom.Text = Convert.ToString(DataGridViewUser.CurrentRow.Cells["dgvNom"].Value);
                frm.tbTel.Text = Convert.ToString(DataGridViewUser.CurrentRow.Cells["dgvTel"].Value);
                frm.tbAdress.Text = Convert.ToString(DataGridViewUser.CurrentRow.Cells["dgvAdress"].Value);
                
                frm.comboRole.Text = Convert.ToString(DataGridViewUser.CurrentRow.Cells["dgvRole"].Value);
                frm.btnEnregistrer.Text = "Mettre à jour";
                frm.btnEnregistrer.FillColor = Color.DarkBlue;
                frm.StartPosition = FormStartPosition.CenterScreen;

                frm.Show();
            }
            else if (DataGridViewUser.CurrentCell.OwningColumn.Name == "dgvActive")
            {
                int id = Convert.ToInt32(DataGridViewUser.CurrentRow.Cells["dgvid"].Value);
                string status = Convert.ToString(DataGridViewUser.CurrentRow.Cells["dgvActif"].Value);
                Utilisateur user = new Utilisateur();
                
                if (status == "oui")
                {
                    status = "non";
                }else
                {
                    status = "oui";
                }
                user.ChangeStatus(status, id);

                loadData();
            }

        }

        private void DataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        //Reinitialiser le mot de d'un utilisateur
        private void btnPasswordReinitialise_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DataGridViewUser.CurrentRow.Cells["dgvid"].Value);
            Utilisateur user = new Utilisateur();
            string pwd = Utilisateur.HashPassword("12345");
            user.ReinitialiserPassword(pwd, id);
        }

        private void tbRechercheUser_TextChanged(object sender, EventArgs e)
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvNom);
            lb.Items.Add(dgvtel);
            lb.Items.Add(dgvadress);
            lb.Items.Add(dgvpass);
            lb.Items.Add(dgvrole);
            Utilisateur user = new Utilisateur();
            user.DonneesRechercher(DataGridViewUser, lb, tbRechercheUser.Text.Trim());

        }
    }
}
