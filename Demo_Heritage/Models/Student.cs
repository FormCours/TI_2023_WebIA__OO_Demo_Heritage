using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Heritage.Models
{
    public class Student : Person
    {
        private DateTime _birthdate;

        public DateTime Birthdate
        {
            get { return _birthdate; }
            set
            {
                if(value >= DateTime.Today.AddYears(-16))
                {
                    throw new Exception("T'es trop jeune :o");
                }
                _birthdate = value;
            }
        }
        public int PlaceNumber { get; set; }


        public void Study(string course)
        {
            Console.WriteLine($"{Fullname} etudie le cours de {course}");
        }

        public void Play()
        {
            Console.WriteLine($"{Fullname} joue a des jeux !");
        }

        public override void Sleep(int hour)
        {
            this.Play();
            base.Sleep(hour - 2);
        }

        public new void SayHello(Person person)
        {
            Console.WriteLine("Yo !");
        }
    }
}
