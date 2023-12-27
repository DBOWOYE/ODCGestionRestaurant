using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCGestiionRestaurant.content
{
    public class Reservation
    {
       private int id ,idClient ,idTable  ,idEmploye , nombrePlace;
        private String dateHeure;

        // Coonstructeur d'initialisation sans parametre
        public Reservation() { }


        // Constructeur d'initialisation de tous les parametre excepte l'id
        public Reservation(int idClient, int idTable, int idEmploye, int nombrePlace, string dateHeure)
        {
            this.idClient = idClient;
            this.idTable = idTable;
            this.idEmploye = idEmploye;
            this.nombrePlace = nombrePlace;
            this.dateHeure = dateHeure;
        }

        // Constructeur d'initialisation de tous les parametres
        public Reservation(int id, int idClient, int idTable, int idEmploye, int nombrePlace, string dateHeure)
        {
            this.id = id;
            this.idClient = idClient;
            this.idTable = idTable;
            this.idEmploye = idEmploye;
            this.nombrePlace = nombrePlace;
            this.dateHeure = dateHeure;
        }

        public int Id { get => id; set => id = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public int IdEmploye { get => idEmploye; set => idEmploye = value; }
        public int NombrePlace { get => nombrePlace; set => nombrePlace = value; }
        public string DateHeure { get => dateHeure; set => dateHeure = value; }

     public bool reserver() { return true; }
     public bool retirerReserver() { return true; }
    }
}
