using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionRestaurant.Model;

namespace GestionRestaurant.Views
{
    public partial class FrmNewTable : Form
    {
        public int id = 0;
        public FrmNewTable()
        {
            InitializeComponent();
        }

        private void BtnFermerTable_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEnregistrerTable_Click(object sender, EventArgs e)
        {
           string nom =  tbTableNom.Text.Trim();
           int place = Convert.ToInt32(tbTablePlace.Text.Trim());
            Table table = new Table();

            if( nom.Length > 0 && place > 0) { 
                if(id == 0){
                    if(table.VerifierTable(nom) == false)
                    {
                        table.Insert(nom, place);
                        this.Close();
                    }
                    
                }else{

                    table.Update(nom, place, id);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        } 
    }
}
