using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsAppliContact
{
    public class ContactDB
    {
        public static Contact MapperUnContact(MySqlDataReader myDataReader)
        {
            int unId = (int)myDataReader["id"];
            string unName = (string)myDataReader["name"];
            string unTel = (string)myDataReader["tel"];

            Contact leContact = new Contact(unId, unName, unTel);

            return leContact;
        }

        public static int AddContact(int unId, string unNom, string unTel)
        {
            int rep = 0;
            MySqlConnection myConnection = ConnexionBdd.InitConnexion();
            if (myConnection != null) // si la connexion reussi
            {
                string query = "INSERT INTO contact(id, name, tel) VALUES(@id, @name, @tel)"; // Texte de la requete SQL
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, myConnection); // creation de la commande avec la requete et la connexion

                    cmd.Parameters.AddWithValue("@id", unId); // initialiser les valeurs des parametre de la requete SQL
                    cmd.Parameters.AddWithValue("@name", unNom);
                    cmd.Parameters.AddWithValue("@tel", unTel);

                    rep = cmd.ExecuteNonQuery(); // execution de la commande et renvoi le nombre de ligne
                }
                catch (Exception ex) // afin de gerer les erreurs
                {
                    Console.WriteLine($"Erreur d'insertion : {ex.Message}");
                }
            }
            return rep;
        }

        public static string GetUnContact(int unId)
        {
            MySqlConnection myConnection = ConnexionBdd.InitConnexion();
            string stringRep = "";
            if (myConnection != null)
            {
                string query = "SELECT * FROM contact WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, myConnection);

                cmd.Parameters.AddWithValue("@id", unId);

                MySqlDataReader mySqlDataReader = cmd.ExecuteReader(); // execution et récuperatio ndu resultat dans un datareader

                if (mySqlDataReader.HasRows) // si la requete a un resultat
                {
                    while (mySqlDataReader.Read())
                    {
                        stringRep += $"\nContact trouvé : {mySqlDataReader[0]} - {mySqlDataReader[1]} -  {mySqlDataReader[2]}";
                    }
                }
                else
                {
                    stringRep = "Aucun contact trouvé ayant cet id dans la base de données";
                }
                mySqlDataReader.Close();
            }
            return stringRep;
        }

        public static List<Contact> GetAllContact()
        {
            List<Contact> listeContacts = new List<Contact>();
            MySqlConnection myConnection = ConnexionBdd.InitConnexion();

            if (myConnection != null)
            {
                string query = "SELECT * FROM contact";

                MySqlCommand cmd = new MySqlCommand(query, myConnection);

                MySqlDataReader myDataReader = cmd.ExecuteReader();

                if (myDataReader.HasRows)
                {
                    while (myDataReader.Read())
                    {
                        Contact unContact = MapperUnContact(myDataReader);
                        listeContacts.Add(unContact);
                    }
                }
                myDataReader.Close();
            }
            return listeContacts;
        }

        public static int DeleteContact(string unName)
        {
            MySqlConnection myConnection = ConnexionBdd.InitConnexion();

            string query = "DELETE FROM contact WHERE name = @name";

            MySqlCommand cmd = new MySqlCommand(query, myConnection);

            cmd.Parameters.AddWithValue("@name", unName);

            int rep = cmd.ExecuteNonQuery();

            return rep;
        }

        public static int UpdateContact(int unId, string unNouveauNom, string unNouveauTel)
        {
            MySqlConnection myConnection = ConnexionBdd.InitConnexion();

            string query = "UPDATE contact SET name=@name, tel=@tel WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(query, myConnection);

            cmd.Parameters.AddWithValue("@id", unId);
            cmd.Parameters.AddWithValue("@name", unNouveauNom);
            cmd.Parameters.AddWithValue("@tel", unNouveauTel);

            int rep = cmd.ExecuteNonQuery();

            return rep;
        }
    }
}
