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
    public partial class Reserver : Form
    {
        Main main = new Main();
        int id_Chambre;
        public Reserver(int id_chambre)
        {
            InitializeComponent();
            this.id_Chambre = id_chambre;
        }

        private void Reserver_Load(object sender, EventArgs e)
        {

        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {
            if(NomTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Remplir votre Nom");
                return;
            }
            if(PrenomtextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Remplir votre Prénom");
                return;
            }
            if(AdressetextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Remplir votre Adresse");
                return;
            }
            if(VilletextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Remplir votre Ville");
                return;
            }
            if(Code_postaltextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Remplir le code postale de votre ville");
                return;
            }
            if(PaystextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Remplir votre Pays");
                return;
            }
            if(TelephonetextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Remplir votre numéro de telephone");
                return;
            }
            if(EmailtextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Remplir votre Email");
                return;
            }
            if(btnSubmit.Text == "Réserver")
            {
                Client client = new Client(NomTextBox.Text.Trim(),
                    PrenomtextBox.Text.Trim(),
                    AdressetextBox.Text.Trim(),
                    VilletextBox.Text.Trim(),
                    Code_postaltextBox.Text.Trim(),
                    PaystextBox.Text.Trim(), 
                    TelephonetextBox.Text.Trim(), 
                    EmailtextBox.Text.Trim());
                main.AddClient(client);
                MessageBox.Show("Informations Added successfilly");
                Reservation reservation = new Reservation(this.id_Chambre, client.Id_Client);
                reservation.Visible = true;
                this.Visible = false;


            }

            
        }

        private void ReservationPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
