using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCGestiionRestaurant.content
{
    public class Ingredient
    {
        private int id;
        private string nom;
        private double prix;
        public Ingredient() { }

        public Ingredient(string nom, double prix)
        {
            this.nom = nom;
            this.prix = prix;
        }
        public Ingredient(int id, string nom, double prix)
        {
            this.id = id;
            this.nom = nom;
            this.prix = prix;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public double Prix { get => prix; set => prix = value; }

        public void ajouter() { }
        public bool modifier(Ingredient ingredient) { return false; }
        public bool suprimmer() { return false; }
    }
}
