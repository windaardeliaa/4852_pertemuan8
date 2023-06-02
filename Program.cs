using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("( hasil output dari class Person )");
            Person person1 = new Person("Brian Kang", 19);
            person1.InfoPerson();
            Console.WriteLine("");
            Console.WriteLine("================================");
            Console.WriteLine("");
            Console.WriteLine("( hasil output dari class Karyawan )");
            Karyawan karyawan1 = new Karyawan("09876545", "Dosen", "Jae", 29);
            karyawan1.InfoPerson();
            karyawan1.InfoKaryawan();
            
          
            Console.ReadKey();
        }

    }
}
