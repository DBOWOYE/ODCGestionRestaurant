using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCGestiionRestaurant.content
{
    public class Commande
    {
        private int id, idClient, idEmploye, montant;
        private String avisClient, dateHeure;
        private bool status;


        // Coonstructeur d'initialisation sans parametre
        public Commande() { }


        // Constructeur d'initialisation de tous les parametre excepte l'id
        public Commande(int id, int idClient, int idEmploye, int montant, string avisClient, string dateHeure, bool status)
        {
            this.id = id;
            this.idClient = idClient;
            this.idEmploye = idEmploye;
            this.montant = montant;
            this.avisClient = avisClient;
            this.dateHeure = dateHeure;
            this.status = status;
        }

        // Constructeur d'initialisation de tous les parametre excepte l'id
        public Commande( int idClient, int idEmploye, int montant, string avisClient, string dateHeure, bool status)
        {
            this.idClient = idClient;
            this.idEmploye = idEmploye;
            this.montant = montant;
            this.avisClient = avisClient;
            this.dateHeure = dateHeure;
            this.status = status;
        }

        public int Id { get => id; set => id = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public int IdEmploye { get => idEmploye; set => idEmploye = value; }
        public int Montant { get => montant; set => montant = value; }
        public string AvisClient { get => avisClient; set => avisClient = value; }
        public string DateHeure { get => dateHeure; set => dateHeure = value; }
        public bool Status { get => status; set => status = value; }

        public bool ajouter() { return false; }
        public bool modifier(Commande commande) { return false; }
        public bool annuler() { return false; }
        public double calculeMontant() { return 0; }
    }
}
