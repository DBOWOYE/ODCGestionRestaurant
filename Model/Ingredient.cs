using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionRestaurant.Model
{
    internal class Ingredient:DBConnect
    {
        string nom;

        public string Nom { get => nom; set => nom = value; }

        public void Insert(Ingredient ing)
        {
            string query = "INSERT INTO `ingredients`(`ingredient`) VALUES ('"+ing.Nom+"')";
            if (this.OpenConnection()== true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    MessageBox.Show("Ingredient enregistrée avec succès !");

                }
                catch (MySqlException)
                {
                    MessageBox.Show("Cet ingrédient existe deja !");

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public void Update(Ingredient ing, int id)
        {
            string query = "UPDATE `ingredients` SET `ingredient` = '"+ ing.Nom + "' WHERE `id` = '"+id+"'";
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    MessageBox.Show("Modification enregistrée avec succès !");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


        public void Delete(int id)
        {
            string query = "DELETE FROM `ingredients` WHERE `id` = '"+id+"'";
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    MessageBox.Show("Suppréssion effectuée avec succès !");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
            String query = "Select * from `ingredients` where `ingredient` LIKE '%" + val + "%' ";
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
