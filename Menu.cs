using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCGestiionRestaurant.content
{
    public class Menu
    {
        private int id;
        private String nom, description;
        public Menu() { }

        public Menu( string nom, string description)
        {
            this.nom = nom;
            this.description = description;
        }
        public Menu(int id, string nom, string description)
        {
            this.id = id;
            this.nom = nom;
            this.description = description;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Description { get => description; set => description = value; }


        public void ajouter() { }
        public bool modifier( Menu menu) { return false; }
        public bool suprimmer() { return false; }

        public bool ajouterPlat(int idPlat) {  return false; }
        public bool retirerPlat(int idPlat) {  return false; }

        public override string ToString() { return ""; }
    }
}
