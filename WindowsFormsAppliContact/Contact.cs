using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppliContact
{
    public class Contact
    {
        private int id;
        private string name;
        private string tel;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }

        public Contact()
        {

        }

        public Contact(int unId, string unName, string unTel)
        {
            this.Id = unId;
            this.Name = unName;
            this.Tel = unTel;
        }
    }
}
