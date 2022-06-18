using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCAPP.Data;
using UCAPP.UC;

namespace UCAPP
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        public void ShowHotels()
        {
            Main main = new Main();
            List<Hotel> Hotels = new List<Hotel>();
            Hotels =  main.SelectHotels();
            int y = 0;
            foreach(Hotel Hotel in Hotels)
            {
                ucHotel h = new ucHotel(this);
                h.Nom = Hotel.Nom;
                h.Adresse = Hotel.Adresse;
                h.Telephone = Hotel.Telephone;
                h.Id_hotel = Hotel.Id_hotel;
                h.Etoile = Hotel.Etoile;
                h.Location = new System.Drawing.Point(1,1+y);
                this.Hotelspanel.Controls.Add(h);
                y += h.Height + 10; 
            }
        }
        public  void ShowRooms(int id_hotel)
        {
            Hotelspanel.Visible = false;
            RoomsPanel.Size = new Size(911, 562);
            RoomsPanel.Location = new Point(229, 9);
            RoomsPanel.Visible = true;
            Main main = new Main();
            List<Chambre> Chambres = new List<Chambre>();
            Chambres = main.SelectChambres(id_hotel);
            int y = 0;
            foreach (Chambre Chambre in Chambres)
            {
                ucRoom r = new ucRoom();
                r.Num = Chambre.Numero;
                r.Id_Categorie = Chambre.Id_categorie;
                r.Id_Chambre = Chambre.Id_chambre;
                r.Id_Hotel = Chambre.Id_hotel;
                r.Telephone = Chambre.Telephone;
                r.Location = new System.Drawing.Point(1, 1 + y);
                RoomsPanel.Controls.Add(r);
                y += r.Height + 10;
            }
        }

       

        private void Accueil_Load(object sender, EventArgs e)
        {
            Hotelspanel.Size = new Size(911, 562);
            Hotelspanel.Location = new Point(229, 9);
            ShowHotels();
        }

        private void Hotelspanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void pictureBox2_Click(object sender, EventArgs e)
        {
            RoomsPanel.Visible = false;
            Hotelspanel.Size = new Size(911, 562);
            Hotelspanel.Location = new Point(229, 9);
            Hotelspanel.Visible = true;
            ShowHotels();
        }
    }
}
