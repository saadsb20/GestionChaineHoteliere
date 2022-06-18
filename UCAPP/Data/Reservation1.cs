using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCAPP.Data
{ 
    public class Reservation1
    {
        public List<Chambre> Chambres { get; set; }
        public int Id_Chambre;
        public int Id_Client;
        public DateTime Periode;
        public int Id_Reservation;

        public Reservation1()
        {
           
        }
        public Reservation1(int id_Reservation, int id_Chambre, int id_Client, DateTime Periode)
        {
            this.Id_Reservation = id_Reservation;
            this.Id_Chambre = id_Chambre;
            this.Id_Client = id_Client;
            this.Periode = Periode;
        }
        public Reservation1(int id_Chambre, int id_Client, DateTime Periode)
        { 
            this.Id_Chambre = id_Chambre;
            this.Id_Client = id_Client;
            this.Periode = Periode;
        }

    }
}
