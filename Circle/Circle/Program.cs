using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            string studname = Console.ReadLine();
            string studlast = Console.ReadLine();
            double studgpa = double.Parse(Console.ReadLine());

            Student studente = new Student(studname, studlast, studgpa);
            Console.WriteLine(studente);
            Console.ReadKey();
        }
    }
}
