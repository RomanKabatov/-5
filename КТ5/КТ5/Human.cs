using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ5
{
    class Human
    {
        protected string name;
        protected string surname;
        protected bool sex;
        public Human(string _name, string _surname, bool _sex)

        {

            name = _name;

            surname = _surname;

            sex = _sex;

        }

        public void Print()

        {

            Console.WriteLine("name: {0}", name);

            Console.WriteLine("surname: {0}", surname);

            if (sex)

                Console.WriteLine("sex: Female");

            else

                Console.WriteLine("sex: Male");

        }
    }
}
