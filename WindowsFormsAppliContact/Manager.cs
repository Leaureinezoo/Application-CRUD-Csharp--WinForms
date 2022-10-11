using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppliContact
{
    public class Manager
    {
        private static List<Contact> lesContacts;

        public static List<Contact> LesContacts { get => lesContacts; set => lesContacts = value; }

        public static void ChargerLesContacts()
        {
            LesContacts = ContactDB.GetAllContact();
        }

        public static int AjouterContact(Contact unContact)
        {
            int unId = unContact.Id;
            string unNom = unContact.Name;
            string unTel = unContact.Tel;

            int nbLigne = ContactDB.AddContact(unId, unNom, unTel);
            return nbLigne;
        }

        public static Contact InstancierContact(int unId, string unNom, string unTel)
        {
            Contact nouveauContact = new Contact(unId, unNom, unTel);
            return nouveauContact;
        }

        public static int SupprimerContact(string unName)
        {
            int nbLigne = ContactDB.DeleteContact(unName);
            return nbLigne;
        }

        public static void ModifierContact(string NomDuContact, string unNouveauNom, string unNouveauTel)
        {
            int rep;
            Contact contactAModifier;
            foreach(Contact contact in Manager.lesContacts)
            {
                if (contact.Name == NomDuContact)
                {
                    contactAModifier = contact;
                    int unId = contactAModifier.Id;

                    rep = ContactDB.UpdateContact(unId, unNouveauNom, unNouveauTel);
                    break;
                }
                else
                {
                    rep = 0;
                }
            }
        }
    }
}
