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

namespace UCAPP
{
    public partial class ucHotel : UserControl
    {
        public string Nom {get;set;}
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public int Id_hotel { get; set; }
        public int Etoile { get; set; }
        private Accueil Accueil;

        public ucHotel(Accueil accueil)
        {
            InitializeComponent();
            Accueil = accueil;
        }

        private void ucHotel_Load(object sender, EventArgs e)
        {
            label.Text = Nom;
            AdresseLabel.Text = Adresse;
            TelephoneLabel.Text = Telephone;
            int x = 0;
            for(int i = 0; i < Etoile; i++)
            {
                PictureBox p = new PictureBox();
                p.ImageLocation = @"D:\star.png";
                p.Location = new System.Drawing.Point(1+x,1);
                p.Size = new System.Drawing.Size(20, 20);
                p.SizeMode = PictureBoxSizeMode.Zoom;
                EtoilesPanel.Controls.Add(p);
                x += p.Width;

            }
        }

        private void btnConsulter_Click(object sender, EventArgs e)
        {
            this.Accueil.ShowRooms(this.Id_hotel);
           
        }
    }
}
