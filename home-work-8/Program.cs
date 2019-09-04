using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_8
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary.Person person = new ClassLibrary.Person();
            ClassLibrary.StaticMethodClass.ShowPerson(person);

            Constant constant = new Constant();
            Console.WriteLine(constant.Name);
            Console.WriteLine(constant.Age);
            Console.WriteLine(constant.Height);
            Console.ReadKey();

        }
    }
}
