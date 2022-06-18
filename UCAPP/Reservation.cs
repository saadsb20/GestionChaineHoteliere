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
    public partial class Reservation : Form
    {
        int Id_Chambre;
        int Id_Client;
        public Reservation(int id_chambre,int id_client)
        {
            InitializeComponent();
            this.Id_Chambre = id_chambre;
            this.Id_Client = id_client;
        }

        private void BrandPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void btnConfirmer_Click(object sender, EventArgs e)
        {
            Reservation1 reservation = new Reservation1(this.Id_Chambre, this.Id_Client, PeriodPicker.Value);
            Main main = new Main();
            main.AddReservation(reservation);
            MessageBox.Show("Reservation Added Successfully");
            this.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
