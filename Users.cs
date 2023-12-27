using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCGestiionRestaurant.content
{
    public class Users : Personnel
    {
        private String password, datEmbauche;
        private Role role;

        // Constructeur initiale sans parametre 
        public Users() { }

        // Constructeur d'initialisation de tous les parametre excepte l'id
        public Users(String nom, String prenom, String adresse, String genre, String telephone, String password , String dateEmbauche)
            : base(nom, prenom, adresse, genre, telephone)
        {

            this.password = password;
            this.datEmbauche = datEmbauche;
        }

        // Constructeur d'initialisation de tous les parametres

        public Users(int id, String nom, String prenom, String adresse, String genre, String telephone, String password, String dateEmbauche)
            : base(id, nom, prenom, adresse, genre, telephone)
        {

            this.password = password;
            this.datEmbauche = datEmbauche;
        }



        public string Password { get => password; set => password = value; }
        public string DatEmbauche { get => datEmbauche; set => datEmbauche = value; }
        public Role Role { get => role; set => role = value; }

        public override bool ajouter()
        {

            return true;
        }

        public override void lister()
        {

        }

        public  bool modifier(Users users , int id)
        {
            return false;
        }

        public override object rechercher( int id)
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


    public enum Role
    {
        ADMIN,GERANT,CUISINIER
    }
}
