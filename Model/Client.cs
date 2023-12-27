using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GestionRestaurant.Model
{
    internal class Client:DBConnect
    {
        int id;
        string nom, prenom, telephone, adresse, genre;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Id { get => id; set => id = value; }



        public void Insert(Client clt)
        {
            string query = "INSERT INTO `clients` (`nom`, `prenom`, `telephone`, `adresse`,`genre`) " +
                "VALUES ('" + clt.Nom + "','" + clt.Prenom + "','" + clt.Telephone + "','" + clt.Adresse + "','" 
                + clt.Genre + "')";

            if (this.OpenConnection() == true)
            {
                try
                {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                        MessageBox.Show("Client enregistré avec succès !");
                    

                }
                catch (MySqlException)
                {
                    MessageBox.Show("Cet enregistrement existe deja !");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    this.CloseConnection();
                }

            }
        }

        public void Update(Client clt, int id)
        {
            string query = "UPDATE `clients` SET `nom`='" + clt.Nom + "',  `prenom`='" + clt.Prenom + "',`telephone`='" + clt.Telephone +
                "',`adresse`='" + clt.Adresse + "',`genre`='" + clt.Genre + "' WHERE `id` = '" + id + "' ";
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    MessageBox.Show("Mise à jour effectuée avec succès !");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    this.CloseConnection();
                }

            }


        }

        public void Delete(int id)
        {
            string query = "DELETE FROM `clients` WHERE `id` = '" + id + "' ";
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    MessageBox.Show("Suppression effectué avec succès !");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    this.CloseConnection();
                }

            }


        }

        public void ChargementDonnees(String query, DataGridView gv, ListBox lb)
        {

            try
            {
                MySqlDataAdapter mySqlDataAdapter =
               new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNom1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNom1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
                CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                CloseConnection();
            }

        }
        public void DonneesRechercher(DataGridView gv, ListBox lb, string val)
        {
            String query = "Select * from `clients` where `telephone` LIKE '%" + val + "%' OR `nom` LIKE '%" + val + "%' OR `adresse` LIKE '%" + val + "%' OR `prenom` LIKE '%" + val + "%' OR `genre` LIKE '%\" + val + \"%'";
            try
            {
                MySqlDataAdapter mySqlDataAdapter =
               new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNom1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNom1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
                CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                CloseConnection();
            }

        }



        public void ChargerDonnees(DataGridView gv, ListBox lb, string val)
        {
            String query = "Select * from `utilisateur`";
            try
            {
                MySqlDataAdapter mySqlDataAdapter =
               new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNom1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNom1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
                CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                CloseConnection();
            }

        }













    }
}
