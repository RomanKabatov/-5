using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ5
{
    sealed class ForeignCitizen : Human
    {
        private string foreignPassport;
        private DateTime visaOpen;
        private DateTime visaClose;

        public ForeignCitizen(string _name, string _surname, bool _sex, string _password, string _address, string _foreignPassport, DateTime _visaOpen, DateTime _visaClose) : base(_name, _surname, _sex)

        {

            foreignPassport = _foreignPassport;

            visaOpen = _visaOpen;

            visaClose = _visaClose;

        }

        public string ForeignPassport { get { return foreignPassport; } set { foreignPassport = value; } }

        public DateTime VisaOpen { get { return visaOpen; } set { visaOpen = value; } }

        public DateTime VisaClose { get { return visaClose; } set { visaClose = value; } }


    }
}
