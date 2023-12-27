using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCGestiionRestaurant.content
{
    public class Table
    {
        private int id, nombrePlace;
        private string nom;
        private bool disponible;

        // Coonstructeur d'initialisation sans parametre
        public Table() { }

        // Constructeur d'initialisation de tous les parametre excepte l'id
        public Table(int nombrePlace, string nom, bool disponible)
        {
            this.nombrePlace = nombrePlace;
            this.nom = nom;
            this.disponible = disponible;
        }

        // Constructeur d'initialisation de tous les parametre excepte l'id
        public Table(int id, int nombrePlace, string nom, bool disponible)
        {
            this.id = id;
            this.nombrePlace = nombrePlace;
            this.nom = nom;
            this.disponible = disponible;
        }

        public int Id { get => id; set => id = value; }
        public int NombrePlace { get => nombrePlace; set => nombrePlace = value; }
        public string Nom { get => nom; set => nom = value; }
        public bool Disponible { get => disponible; set => disponible = value; }

        public bool ajouter() {  return false; }
        public bool retirer() { return false; }

        public bool modifier( int id) {  return false; }

        public void lister() { }

        public void changerStatus()
        {
            this.disponible = !this.disponible;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }

}
