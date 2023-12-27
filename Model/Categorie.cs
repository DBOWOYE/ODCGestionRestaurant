using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace GestionRestaurant.Model
{
    internal class Categorie:DBConnect
    {
        int id;
        string nom;

        public string Nom { get => nom; set => nom = value; }
        public int Id { get => id; set => id = value; }


        public string RecupererCategorie(String categorie)
        {
            string id = "";
            if (this.OpenConnection() == true) { 
                try
                {
                    string query = "SELECT * FROM `categories` WHERE `nom` = '" + categorie + "';";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        return dataReader["id"].ToString();
                        

                    }

                    dataReader.Close();
                    this.CloseConnection();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    this.CloseConnection();
                }
            
            }
            return id;
        }

        public void Insert(string nom)
        {
            string query = "INSERT INTO `categories` SET `nom` = '" + nom + "'; ";
            if(this.OpenConnection() == true)
            {
                try
                {
                    
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                        MessageBox.Show("Catégorie enregistrée avec succès !");
                   
                    
                }catch (MySqlException)
                {
                    MessageBox.Show("Cette catégorie existe déja !");
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                    this.CloseConnection();
                }
            }

        }

        public void Update(string nom, int id)
        {
            string query = "UPDATE `categories` SET `nom` = '" + nom + "' WHERE `id`= "+id+"; ";
            if (this.OpenConnection() == true)
            {
                try
                {
                   
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                        MessageBox.Show("Modification effectuée avec succès !");
                   

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
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
            String query = "Select * from `categories` where `nom` LIKE '%" + val + "%' ";
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


        public void Delete(int id)
        {
            string query = "DELETE FROM  `categories` WHERE `id` = '" + id + "';";
            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                    MessageBox.Show("Suppression effectuée avec succès !");

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    CloseConnection();
                }
            }
        }












    }
}
