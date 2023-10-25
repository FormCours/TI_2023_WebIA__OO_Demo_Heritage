using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Heritage.Models
{
    public class Teacher : Person
    {
        public List<string> Courses { get; set; }

        public void Teach(string course)
        {
            Console.WriteLine($"{Fullname} donne cours de {course}");
        }

        public void Coach(Student student)
        {
            Console.WriteLine($"{this.Fullname} coach {student.Fullname}");
        }
    }
}
