using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppliContact
{
    public class ConnexionBdd
    {
        private static MySqlConnection connection = null;

        //méthode pour initialiser une connexion
        //retourne un objet de type MySQLConnexion
        //représentant la connexion à la BDD
        public static MySqlConnection InitConnexion()
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=applicontactv2; UID=root; PASSWORD=''";
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"erreur de connexion : {ex.Message}");
            }
            return connection;
        }
    }
}
