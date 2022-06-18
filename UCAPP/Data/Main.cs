using System;
using System.Collections.Generic;
using System.Data;
using n = Npgsql;

namespace UCAPP.Data
{
    class Main
    {
        public List<Hotel> Hotels = new List<Hotel>();
        public List<Chambre> Chambres = new List<Chambre>();
        public List<Category> Categories = new List<Category>();

        static String cnxStr = "server=localhost;port=5432;user id=postgres; password=123456789; database=postgres";
        static n.NpgsqlConnection cnx = new n.NpgsqlConnection(cnxStr);
        static n.NpgsqlCommand  cmd;
        static n.NpgsqlDataAdapter ada;
        
        public  Main()
        {

        }
        public List<Hotel> SelectHotels()
        {
            cmd = new n.NpgsqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM public.\"hotel\"";
            ada = new n.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            DataRow[] currentRows = dt.Select(null, null, DataViewRowState.CurrentRows);

            if (currentRows.Length < 1)
                Console.WriteLine("No Current Rows Found");
            else
            {
                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}", column.ColumnName);

                Console.WriteLine("\tRowState");

                foreach (DataRow row in currentRows)
                {
                    Hotel hotel = new Hotel( Int32.Parse(row[1].ToString()), Int32.Parse(row[4].ToString()), row[3].ToString(), row[2].ToString(), row[0].ToString());
                    Hotels.Add(hotel);


                    Console.WriteLine("++++++++++++++++++++++++++");
                    Console.WriteLine(Int32.Parse(row[1].ToString()));
                    Console.WriteLine( Int32.Parse(row[4].ToString()));
                    Console.WriteLine(row[3].ToString());
                    Console.WriteLine(row[2].ToString());
                    Console.WriteLine(row[0].ToString());

                }
                
            }
            return Hotels;
        }

        public List<Chambre> SelectChambres(int id_hotel)
        {

            cmd = new n.NpgsqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM public.\"Chambre\" WHERE \"Id_hotel\" = " + id_hotel;
            ada = new n.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            DataRow[] currentRows = dt.Select(null, null, DataViewRowState.CurrentRows);

            if (currentRows.Length < 1)
                Console.WriteLine("No Current Rows Found");
            else
            {
                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}", column.ColumnName);

                Console.WriteLine("\tRowState");

                foreach (DataRow row in currentRows)
                {
                    foreach (DataColumn column in dt.Columns)
                        Console.Write("\t{0}", row[column]);
                    Chambre chambre = new Chambre(Int32.Parse(row[0].ToString()), Int32.Parse(row[2].ToString()), Int32.Parse(row[3].ToString()), Int32.Parse(row[4].ToString()), row[1].ToString());
                    Chambres.Add(chambre);


                    Console.WriteLine("++++++++++++++++++++++++++");
                    Console.WriteLine("Numero : " + Int32.Parse(row[0].ToString()));
                    Console.WriteLine("Id_Chambre : " + Int32.Parse(row[2].ToString()));
                    Console.WriteLine("Id_Hotel : " +Int32.Parse(row[3].ToString()));
                    Console.WriteLine("Id_Categorie : " + Int32.Parse(row[4].ToString()));
                    Console.WriteLine("Telephone : " +row[1].ToString());

                }

            }
            return Chambres;
        }
        public Category SelectCategory(int id_category)
        {
            cmd = new n.NpgsqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM public.\"Categorie\" WHERE \"Id_categorie\" = " + id_category;
            ada = new n.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            DataRow[] currentRows = dt.Select(null, null, DataViewRowState.CurrentRows);

            if (currentRows.Length < 1)
                Console.WriteLine("No Current Rows Found");
            else
            {
                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}", column.ColumnName);

                Console.WriteLine("\tRowState");

                foreach (DataRow row in currentRows)
                {
                    foreach (DataColumn column in dt.Columns)
                        Console.Write("\t{0}", row[column]);
                    Category category = new Category(Int32.Parse(row[0].ToString()), row[1].ToString());
                    Categories.Add(category);


                    Console.WriteLine("++++++++++++++++++++++++++");
                    Console.WriteLine("Category id : " + Int32.Parse(row[0].ToString()));
                    Console.WriteLine("Description : " + row[1].ToString());

                }

            }

            return Categories[0];
        }
        public void AddClient(Client client)
        {
            cmd = new n.NpgsqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "INSERT INTO public.\"Client\" VALUES(@Nom,@Prenom,@Adresse,@Ville,@Code_postal,@Pays,@Telephone,@Email)";
            cmd.Parameters.Add("@Nom", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.Nom;
            cmd.Parameters.Add("@Prenom", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.Prenom;
            cmd.Parameters.Add("@Adresse", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.Adresse;
            cmd.Parameters.Add("@Ville", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.Ville;
            cmd.Parameters.Add("@Code_postal", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.Code_Postal;
            cmd.Parameters.Add("@Pays", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.Pays;
            cmd.Parameters.Add("@Telephone", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.Telephone;
            cmd.Parameters.Add("@Email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.Email;
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Client Added Successfully");
                cnx.Close();

            }
            catch (n.NpgsqlException ex)
            {
                Console.WriteLine("Exception : " + ex);
                cnx.Close();
            }
        }
        public void AddReservation(Reservation1 reservation) { 
        cmd = new n.NpgsqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "INSERT INTO public.\"Reservation\" (\"Id_Client\",\"Id_Chambre\",\"Periode\") VALUES(@Id_Client,@Id_Chambre,@Periode)";
            cmd.Parameters.Add("@Id_Chambre", NpgsqlTypes.NpgsqlDbType.Integer).Value = reservation.Id_Chambre;
            cmd.Parameters.Add("@Id_Client", NpgsqlTypes.NpgsqlDbType.Integer).Value = reservation.Id_Client;
            cmd.Parameters.Add("@Periode", NpgsqlTypes.NpgsqlDbType.Date).Value = reservation.Periode;
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Reservation Added Successfully");
                cnx.Close();

            }
            catch (n.NpgsqlException ex)
            {
                Console.WriteLine("Exception : " + ex);
                cnx.Close();
            }
        }
    }
}
