using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppliContact
{
    public class Affichage
    {
        public static string AfficherContact(Contact unContact)
        {
            string stringRep = $"Contact : {unContact.Id} - {unContact.Name} - {unContact.Tel}";
            return stringRep;
        }

        public static string AfficherLesContacts()
        {
            string stringRep = "Les contacts sont :";
            foreach (Contact contact in Manager.LesContacts)
            {
                stringRep += $"\n{AfficherContact(contact)}";
            }
            return stringRep;
        }

        public static string AfficherRepAjouterContact(int rep)
        {
            string stringRep = "";
            if (rep == 1)
            {
                stringRep = "Contact ajouté";
            }
            else
            {
                stringRep = "Contact non ajouté";
            }
            return stringRep;
        }

        public static string AfficherRepSupprimerContact(int rep)
        {
            string stringRep = "";
            if (rep == 1)
            {
                stringRep = "Contact supprimé";
            }
            else
            {
                stringRep = "Contact pas supprimé";
            }
            return stringRep;
        }

        public static string AfficherRepModifierContact(int rep)
        {
            string stringRep = "";
            if (rep == 1)
            {
                stringRep = "Modification effectué";
            }
            else
            {
                stringRep = "Modification non effectué";
            }
            return stringRep;
        }
    }
}
