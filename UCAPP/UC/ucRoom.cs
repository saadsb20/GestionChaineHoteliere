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
using System.IO;

namespace UCAPP.UC
{ 
     
    public partial class ucRoom : UserControl
    {
        Main main = new Main();
        public int Num { get; set; }
        public string Telephone { get; set; }
        public int Id_Chambre { get; set; }
        public int Id_Hotel { get; set; }
        public int Id_Categorie { get; set; }


        public ucRoom()
        {
            InitializeComponent();
        }

        private void ucRoom_Load(object sender, EventArgs e)
        {
            this.TelephoneLabel.Text = Telephone;
            main.SelectCategory(Id_Categorie);
            this.CategoryLabel.Text = Id_Categorie.ToString();
            this.NumeroLabel.Text = Num.ToString();
            
        }

        private void ucRoom_Load_1(object sender, EventArgs e)
        {
            this.TelephoneLabel.Text = Telephone;
            this.CategoryLabel.Text = main.SelectCategory(Id_Categorie).Description;
            this.NumeroLabel.Text = Num.ToString();
        }
        public void btnReserver_Click(object sender, EventArgs e)
        {
            Reserver reserver = new Reserver(this.Id_Chambre);
            reserver.Visible = true;
        }
    }
}

