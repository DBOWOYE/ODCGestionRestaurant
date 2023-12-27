using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.Common;
using System.Security.Cryptography;

namespace GestionRestaurant
{
    internal class Utilisateur : DBConnect
    {
        int id;
        string nom, telephone, adresse, role, status, password;

        public static string userConnect;
        public static string userConnectRole;
        public static string statusConnect;
        public static int idConnect;


        public string Nom { get => nom; set => nom = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string Status { get => status; set => status = value; }
        public int Id { get => id; set => id = value; }

        public static string STATUS
        {
            get { return statusConnect; }
            set => statusConnect = value;
        }
        public static int ID
        {
            get { return idConnect; }
            set => idConnect = value;
        }
        public static string USER
        {
            get { return userConnect; }
            set { userConnect = value; }
        }
        public static string ROLE
        {
            get { return userConnectRole; }
            set { userConnectRole = value; }
        }

        public static string HashPassword(string password)
        {
            // Créer un hachage MD5
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Convertir le hachage en chaîne de caractères
            return BitConverter.ToString(hash).Replace("-", "");
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Créer un hachage MD5
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Convertir le hachage en chaîne de caractères
            string hashString = BitConverter.ToString(hash).Replace("-", "");

            // Comparer le hachage du mot de passe d'entrée au hachage stocké
            return hashString == hashedPassword;
        }

        public void ChargerCombo(ComboBox comboBox)
        {
            if (this.OpenConnection() == true)
            {
                try
                {
                    string query = "SELECT * FROM `role`;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        comboBox.Items.Add(dataReader["role"].ToString());
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
        public bool IsValidUser(string username, string pwd)
        {

            bool isValid = false;

            string query = "SELECT * FROM `utilisateur` WHERE `telephone` = '" + username.ToString() + "' AND `password` = '" + pwd.ToString() + "';";
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        isValid = true;

                        USER = dataReader["nom"].ToString();
                        ROLE = dataReader["role"].ToString();
                        STATUS = dataReader["status"].ToString();
                        ID = Convert.ToInt32(dataReader["id"]);


                    }
                    else
                    {
                        MessageBox.Show("Utilisateur ou mot de passe incorrect !");
                    }

                    this.CloseConnection();

                }
                catch (Exception)
                {
                    MessageBox.Show("Nom d'utilisateur ou le mot de passe incorrect !");
                }
            }


            return isValid;
        }


     
        public void Insert(String nom, String telephone, String adresse, string password, string role)
        {
            string query = "INSERT INTO `utilisateur`(`nom`, `telephone`, `adresse`,`password`, `role`) " +
                "VALUES ('" + nom + "','" + telephone + "','" + adresse + "','" + password + "','" + role + "')";
            if (this.OpenConnection() == true)
            {
                try
                {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                        MessageBox.Show("Utilisateur enregistré avec succès !");
                    
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Cet utilisateur existe deja !");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    this.CloseConnection();
                }

            }
        }

        public void Update(String nom, String telephone, String adresse, string role, int id)
        {
            string query = "UPDATE `utilisateur` SET `nom`='" + nom + "',`telephone`='" + telephone +
                "',`adresse`='" + adresse + "',`role`='" + role + "' WHERE `id` = '" + id + "' ";
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
            String query = "Select * from `utilisateur` where `telephone` LIKE '%" + val + "%' OR `nom` LIKE '%" + val + "%' OR `adresse` LIKE '%" + val + "%' OR `role` LIKE '%" + val + "%'";
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

        public void ChangeStatus(String status, int id)
        {
            string query = "UPDATE `utilisateur` SET `status`='" + status + "' WHERE `id` = '" + id + "' ";
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    MessageBox.Show("Status changé avec succès !");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    this.CloseConnection();
                }

            }


        }

        //Reinitialiser le mot de passe selectionné
        public void ReinitialiserPassword(String pwd, int id)
        {
            string query = "UPDATE `utilisateur` SET `password`='" + pwd + "' WHERE `id` = '" + id + "' ";
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();

                    MessageBox.Show("Mise à jour du mot de passe effectuée avec succès !");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    this.CloseConnection();
                }

            }


        }

        //Modifier le mot de passe de l'utilisateur

        public void ChangePassword(String pwd, int id)
        {
            string query = "UPDATE `utilisateur` SET `password`='" + pwd + "' WHERE `id` = '" + id + "' ";
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();

                    MessageBox.Show("Mise à jour du mot de passe effectuée avec succès !");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    this.CloseConnection();
                }

            }


        }

        public void Delete(string table, int id)
        {
            string query = "DELETE FROM " + table + " WHERE id = " + id + ";";
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
