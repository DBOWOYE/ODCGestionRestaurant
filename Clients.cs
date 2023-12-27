using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCGestiionRestaurant.content
{
    public class Clients : Personnel
    {

        private String alergie;

        // Constructeur initiale sans parametre 
        public Clients() { }

        // Constructeur d'initialisation de tous les parametre excepte l'id
        public Clients(String nom, String prenom, String adresse, String genre, String telephone, String alergie)
            : base( nom, prenom, adresse, genre , telephone)
        {
       
            this.alergie = alergie;
        }

        // Constructeur d'initialisation de tous les parametres

        public Clients(int id, String nom, String prenom, String adresse, String genre, String telephone, String alergie)
            : base(id, nom, prenom, adresse, genre, telephone)
        {

            this.alergie = alergie;
        }

        public string Alergie { get => alergie; set => alergie = value; }

        public override bool ajouter()
        {
          
            return true;
        }

        public override void lister()
        {

        }

        public  bool modifier(Clients client, int id)
        {
            return false;
        }

        public override object rechercher(int id)
        {
            return new Object();
        }

        public override bool supprimer()
        {
            return true;
        }

        public override string ToString()
        {

            // Formatage de l'affichage
            return base.ToString();
        }
    }
}
