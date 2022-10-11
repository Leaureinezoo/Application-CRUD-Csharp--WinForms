using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppliContact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Manager.ChargerLesContacts();
            foreach (Contact contact in Manager.LesContacts)
            {
                ListNomContact.Items.Add(contact.Name);
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            if (txtBoxIdUpdateDetails.Text != null && txtBoxNameUpdateDetails.Text != null && txtBoxNumberUpdateDetails != null && ListNomContact.SelectedIndex != -1)
            {
                Manager.ModifierContact(ListNomContact.SelectedItem.ToString(), txtBoxNameUpdateDetails.Text, txtBoxNumberUpdateDetails.Text);
                ListNomContact.Items.Clear();
                Manager.ChargerLesContacts();
                foreach (Contact contact in Manager.LesContacts)
                {
                    ListNomContact.Items.Add(contact.Name);
                }
                labelErreurDetails.Text = "";
            }
            else
            {
                labelErreurDetails.Text = "Erreur";
            }
        }

        private void buttonSupp_Click(object sender, EventArgs e)
        {
            Manager.SupprimerContact(ListNomContact.SelectedItem.ToString());
            ListNomContact.Items.Clear();
            Manager.ChargerLesContacts();
            foreach (Contact contact in Manager.LesContacts)
            {
                ListNomContact.Items.Add(contact.Name);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxIdAdd.Text != null && txtBoxNameAdd != null && txtBoxNumberAdd != null)
            {
                Contact contactAAjouter = Manager.InstancierContact(Convert.ToInt32(txtBoxIdAdd.Text), txtBoxNameAdd.Text, txtBoxNumberAdd.Text);
                int nbligne = Manager.AjouterContact(contactAAjouter);
                ListNomContact.Items.Clear();
                Manager.ChargerLesContacts();
                foreach (Contact contact in Manager.LesContacts)
                {
                    ListNomContact.Items.Add(contact.Name);
                }
                txtBoxIdAdd.Clear();
                txtBoxNameAdd.Clear();
                txtBoxNumberAdd.Clear();
                labelErreurAdd.Text = "";
            }
            else
            {
                labelErreurAdd.Text = "Erreur"; 
            }
        }

        private void ListNomContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListNomContact.SelectedIndex != -1)
            {
                Contact contactAAfficher = null;
                foreach (Contact contact in Manager.LesContacts)
                {
                    if (ListNomContact.SelectedItem.ToString() == contact.Name)
                    {
                        contactAAfficher = contact;
                        break;
                    }
                    else
                    {
                        contactAAfficher = null;
                    }
                }
                txtBoxIdUpdateDetails.Text = Convert.ToString(contactAAfficher.Id);
                txtBoxNameUpdateDetails.Text = contactAAfficher.Name;
                txtBoxNumberUpdateDetails.Text = contactAAfficher.Tel;
            }
        }
    }
}
