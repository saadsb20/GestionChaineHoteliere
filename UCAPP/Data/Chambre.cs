using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCAPP.Data
{
    public class Chambre
    {
        public int Numero { get; set; }
        public int Id_chambre { get; set; }
        public int Id_hotel { get; set; }
        public int Id_categorie { get; set; }
        public string Telephone { get; set; }


        public Chambre()
        {

        }


        public Chambre(Int32 Numero, Int32 Id_chambre, Int32 Id_hotel, Int32 Id_categorie, String Telephone)
        {
            this.Numero = Numero;
            this.Id_categorie = Id_categorie;
            this.Id_hotel = Id_hotel;
            this.Id_chambre = Id_chambre;
            this.Telephone = Telephone;  
        }
        
    }
}
