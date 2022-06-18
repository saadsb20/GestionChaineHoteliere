using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using n = Npgsql;

namespace UCAPP.Data
{
    class Hotel
    {

        public String Nom { get; set; }
        public String Adresse { get; set; }
        public String Telephone { get; set; }
        public int  Id_hotel { get; set; }
        public int Etoile { get; set; }


        public Hotel()
        {

        }


        public Hotel(Int32 id,Int32 Etoile,String Telephone,String Adresse,String Nom) {
            this.Adresse = Adresse;
            this.Etoile = Etoile;
            this.Id_hotel = id;
            this.Nom = Nom;
            this.Telephone = Telephone;
        }
    }
}
