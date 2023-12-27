using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCGestiionRestaurant.content
{
    public abstract class  Personnel
    {
        private int id;
        private String nom, prenom, adresse, genre, telephone;


        // Constructeur initiale sans parametre 
        public Personnel(){ }

        // Constructeur d'initialisation de tous les parametre excepte l'id
        public Personnel(String nom, String prenom, String adresse, String genre, String telephone)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.genre = genre;
            this.telephone = telephone;
        }
        
        // Constructeur d'initialisation de tous les parametres

        public Personnel(int id, String nom, String prenom, String adresse, String genre, String telephone)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.genre = genre;
            this.telephone = telephone;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Telephone { get => telephone; set => telephone = value; }


        public abstract bool ajouter();
        public abstract bool supprimer();
        public abstract void lister();
        public abstract Object rechercher(int id);

    }
}
