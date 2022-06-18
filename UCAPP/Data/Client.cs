using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCAPP.Data
{
    class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string Code_Postal { get; set; }
        public string Pays { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int Id_Client { get; set; }

        public Client()
        {

        }
        public Client(string Nom, string Prenom, string Adresse, string Ville, string Code_Postal, string Pays, string Telephone, string Email)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Adresse = Adresse;
            this.Ville = Ville;
            this.Code_Postal = Code_Postal;
            this.Pays = Pays;
            this.Telephone = Telephone;
            this.Email = Email;
        }
        public Client(string Nom, string Prenom, string Adresse, string Ville, string Code_Postal, string Pays, string Telephone, string Email, int Id_Client)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Adresse = Adresse;
            this.Ville = Ville;
            this.Code_Postal = Code_Postal;
            this.Pays = Pays;
            this.Telephone = Telephone;
            this.Email = Email;
            this.Id_Client = Id_Client;
        }
    }
}
