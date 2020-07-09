using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VapeApplication
{
    class Seller
    {
        private static Seller seller;

        private int id;
        private String firstName;
        private String lastName;
        private  String patronymicName;
        private String login;
        private String password;

        private Seller(int id, String firstName, String lastName
            , String patronymicName, String login, String password)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.patronymicName = patronymicName;
            this.login = login;
            this.password = password;
        }

        public static Seller getSeller()
        {
            return seller;
        }

        public static Seller CreateSeller(int id, String firstName, String lastName
            , String patronymicName, String login, String password)
        {
                seller = new Seller(id, firstName, lastName, patronymicName, login, password);
            return seller;
        }

        public int Id
        {
            get { return id; }
        }

        public String FirstName
        {
            get { return firstName; }
        }

        public String LastName
        {
            get { return lastName; }
        }

        public String PatronymicName
        {
            get { return patronymicName; }
        }
    }
}
