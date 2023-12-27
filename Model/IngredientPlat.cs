using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODCGestiionRestaurant.content
{
    public class IngredientPlat
    {
        private int id, idIngredient, idPlat;
        public IngredientPlat() { }

        public IngredientPlat( int idIngredient, int idPlat)
        {
            this.idIngredient = idIngredient;
            this.idPlat = idPlat;
        }
        public IngredientPlat(int id, int idIngredient, int idPlat)
        {
            this.id = id;
            this.idIngredient = idIngredient;
            this.idPlat = idPlat;
        }

        public int Id { get => id; set => id = value; }
        public int IdIngredient { get => idIngredient; set => idIngredient = value; }
        public int IdPlat { get => idPlat; set => idPlat = value; }
    }
}
