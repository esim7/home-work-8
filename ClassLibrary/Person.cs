using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        public string _name { get; set; }
        public int _age { get; set; }
        public string _phoneNumber { get; set; }

        public Person()
        {
            _name = "Makishev Esimzhan";
            _age = 29;
            _phoneNumber = "+7 778 22 88 999";
        }

        public Person(string Name, int Age, string PhoneNumber)
        {
            _name = Name;
            _age = Age;
            _phoneNumber = PhoneNumber;
        }
    }
}
