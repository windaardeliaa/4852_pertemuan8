using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inheritance
{
    //class Person atau class utama
    public class Person
    {
        //field dari class Person
        string name;
        int age;
    
        //constructor dari class Person
        public Person(string n, int a) 
        {
            this.name = n;
            this.age = a;
        }
        

        //fungsi/method yang akan menampilkan nama dan umur
        public void InfoPerson()
        {
            Console.WriteLine("Nama saya {0} dan umur saya {1} tahun", name, age);
        }
    }

        //kelas karyawan sebagai kelas turunan
        public class Karyawan : Person 
    {

        //properties dari kelas karyawan
        public string karyawanid;
        public string subject; 

        //constructor dari kelas karyawan
        public Karyawan( string kid, string sbj, string n, int a) : base(n, a)
        {
            karyawanid = kid;
            subject = sbj;

        }
  
        //method dari kelas karyawan
        public void InfoKaryawan()
        {
            
            Console.WriteLine("Dengan ID {0} dan saya sebagai {1}", karyawanid, subject);
        }
        //override method dari class Person
        public void InfoPerson(string name, int age)
        {
            
            Console.WriteLine("Nama saya {0} dan umur saya {1} tahun", name, age);
        }

    }
    }