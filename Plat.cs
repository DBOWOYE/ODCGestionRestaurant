using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCGestiionRestaurant.content
{
    public class Plat
    {
        private int id, idMenu;
        private string nom, description;
        private double prix;
        // photo a revoir


        public Plat() { }
        public Plat(int idMenu, string nom, string description, double prix)
        {
            this.idMenu = idMenu;
            this.nom = nom;
            this.description = description;
            this.prix = prix;
        }

        public Plat(int id, int idMenu, string nom, string description, double prix)
        {
            this.id = id;
            this.idMenu = idMenu;
            this.nom = nom;
            this.description = description;
            this.prix = prix;
        }

        public int Id { get => id; set => id = value; }
        public int IdMenu { get => idMenu; set => idMenu = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Description { get => description; set => description = value; }
        public double Prix { get => prix; set => prix = value; }

        public void ajouter() { }
        public bool modifier(Plat plat){ return false; }
        public bool suprimmer() { return false; }

        public bool ajouerIngredient(int id) { return false; }
        public bool retirerIngredient(int id) { return false; }
    }
}
