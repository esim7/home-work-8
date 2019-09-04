using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class StaticMethodClass
    {
        public static void ShowPerson(Person obj)
        {
            Console.WriteLine(obj._name);
            Console.WriteLine(obj._age);
            Console.WriteLine(obj._phoneNumber);
        }
    }
}
