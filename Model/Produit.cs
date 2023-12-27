using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace GestionRestaurant.Model
{
    internal class Produit : DBConnect
    {
        int id, categorie;
        string designation, prix, description;
        byte[] image;

        public int Id { get => id; set => id = value; }
        public int Categorie { get => categorie; set => categorie = value; }
        public string Designation { get => designation; set => designation = value; }
        public string Prix { get => prix; set => prix = value; }
        public string Description { get => description; set => description = value; }
        public byte[] Image { get => image; set => image = value; }

        public void ChargerCombo(ComboBox comboBox)
        {
            if (this.OpenConnection() == true)
            {
                try
                {
                    string query = "SELECT * FROM `categories`;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                   
                    while (dataReader.Read())
                    {
                        string nom = dataReader["nom"].ToString();
                        string id = dataReader["id"].ToString();

                        comboBox.Items.Add(nom);

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
        }

        public void Insert(Produit prod)
        {
            if((this.OpenConnection()) == true)
            {
                try
                {
                    string query = "INSERT INTO `produits` (`id`, `designation`, `description`, `prix`, `idCategorie`, `photo`) " +
                        "VALUES (NULL, '" + prod.Designation + "','" + prod.Description + "','" + prod.prix + "','" + prod.Categorie + "','" + prod.Image + "')";
                    
                    MySqlCommand ms = new MySqlCommand(query, connection);
                    ms.ExecuteNonQuery();
                    this.CloseConnection();
                    
                    MessageBox.Show("Produit enregistré avec succès !");
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ce produit existe deja !");
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
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
    }
}
