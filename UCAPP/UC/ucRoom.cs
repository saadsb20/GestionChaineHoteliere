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

namespace UCAPP.UC
{
    public partial class ucRoom : UserControl
    {
        Reservation reservation = new Reservation();
        public int Num { get; set; }
       
        public ucRoom()
        {
            InitializeComponent();

        }

        private void ucRoom_Load(object sender, EventArgs e)
        {
            lbNum.Text = Num.ToString();
            this.BackColor = reservation.GetStatus(Num);
       
        }

        private void nettoyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chambre Num :"+Num);
        }

        private void réserverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void libérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
    }
}
