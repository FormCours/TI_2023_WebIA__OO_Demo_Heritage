using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Heritage.Models
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Fullname
        {
            //get { return $"{Firstname} {Lastname}";}
            get { return Firstname + " " + Lastname; }
        }


        public virtual void Sleep(int hour)
        {
            Console.WriteLine($"{Fullname} dort {hour} heures!");
        }

        public void SayHello(Person person)
        {
            Console.WriteLine($"Bonjour {person.Firstname}.");
        }
    }
}
