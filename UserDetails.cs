using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strife
{
    class UserDetails
    {
        private int id;
        private string name;
        private string surname;
        private string email;
        private string cell;
        private string unit;
        private string street;
        private string suburb;
        private string province;
        private string country;
        private string password;
        private string zip;
        private string picture;

        //CTRL .   = encapsulate as fields

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Cell { get => cell; set => cell = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Street { get => street; set => street = value; }
        public string Suburb { get => suburb; set => suburb = value; }
        public string Province { get => province; set => province = value; }
        public string Country { get => country; set => country = value; }
        public string Password { get => password; set => password = value; }
        public string Zip { get => zip; set => zip = value; }
        public string Profile { get => picture; set => picture = value; }
        public int Id { get => id; set => id = value; }

        //CTRL .   = generator and unclick the non-variables

        public UserDetails(int id, string name, string surname, string email, string cell, string unit, string street, string suburb, string province, string country, string password, string zip, string picture)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.cell = cell;
            this.unit = unit;
            this.street = street;
            this.suburb = suburb;
            this.province = province;
            this.country = country;
            this.password = password;
            this.zip = zip;
            this.picture = picture;
        }

        public UserDetails()
        {


        }
    }
}
