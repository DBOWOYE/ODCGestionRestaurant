using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCGestiionRestaurant.content
{
    public class DetailCommande
    {
        private int id, idCommande, idPlat, quantite;
        private double prix;

        public DetailCommande(){ }
        public DetailCommande( int idCommande, int idPlat, int quantite, double prix)
        {
            this.idCommande = idCommande;
            this.idPlat = idPlat;
            this.quantite = quantite;
            this.prix = prix;
        }
        public DetailCommande(int id, int idCommande, int idPlat, int quantite, double prix)
        {
            this.id = id;
            this.idCommande = idCommande;
            this.idPlat = idPlat;
            this.quantite = quantite;
            this.prix = prix;
        }

        public int Id { get => id; set => id = value; }
        public int IdCommande { get => idCommande; set => idCommande = value; }
        public int IdPlat { get => idPlat; set => idPlat = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public double Prix { get => prix; set => prix = value; }
    }
}
