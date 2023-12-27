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
    public partial class FrmAddIngredient : Form
    {
        public int id = 0;
        public FrmAddIngredient()
        {
            InitializeComponent();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            string ingredient = tbIngredient.Text.Trim();
            if(ingredient.Length > 0)
            {
                Ingredient ing = new Ingredient();
                ing.Nom = ingredient;
                if(id == 0)
                {
                    ing.Insert(ing);
                    tbIngredient.Text = "";
                }else
                {
                    ing.Update(ing, id);
                    this.Close();
                }
                
            }
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
