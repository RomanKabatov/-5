using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ5
{
    class Citizen : Human
    {
        protected string password;
        protected string address;

        public Citizen(string _name, string _surname, bool _sex, string _password, string _address) : base(_name, _surname, _sex)

        {

            password = _password;

            address = _address;

        }

        public string Password { get { return password; } set { password = value; } }

        public string Address { get { return address; } set { address = value; } }

        public new void Print()

        {

            base.Print(); // вызов метода базового класса      

            Console.WriteLine("password: {0}", password);

            Console.WriteLine("address: {0}", address);

        }
    }
}
