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
    internal class Table:DBConnect
    {
        int id;
        string nom;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }

        public bool VerifierTable(String table)
        {
            bool existe = false;
            if(this.OpenConnection() == true) {
            
                try
                {
                    string query = "SELECT * FROM `tables` WHERE `table` = '" + table + "';";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                
                    if (dataReader.Read())
                    {
                        MessageBox.Show("Cette table existe deja !");
                        existe = true; 
                    }
                    dataReader.Close();
                    this.CloseConnection();
                }
                catch (Exception e)
                {
                    this.CloseConnection();
                    MessageBox.Show(e.ToString());
                }
            }
            return existe;
        }


        public void Insert(string table, int place)
        {
            string query = "INSERT INTO `tables` SET `table` = '" + table + "', `places` = '"+place+"'";

            if (this.OpenConnection() == true)
            {
                try
                {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                        MessageBox.Show("Table enregistrée avec succès !");
                    
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                    this.CloseConnection();
                }
            }

        }

        public void Update(string table,int place, int id)
        {
            string query = "UPDATE `tables` SET `table` = '" + table + "', `places` = '"+place+"' WHERE `id` = '"+id+"' ";

            if (this.OpenConnection() == true)
            {
                try
                {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                        MessageBox.Show("Table modifiée avec succès !");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    this.CloseConnection();
                }
            }

        }

        public void LibererTable(int id)
        {
            string query = "UPDATE `tables` SET `disponible` = 'disponible' WHERE `id` = '" + id + "' ";

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    MessageBox.Show("Table libérée avec succès !");
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
            String query = "Select * from `tables` where `table` LIKE '%" + val + "%' ";
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
            string query = "DELETE FROM  `tables` WHERE `id` = '" + id + "';";
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
