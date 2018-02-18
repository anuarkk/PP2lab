using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleStudent
{
    class Student
    {
        public string Student_name;
        public string Student_2name;
        public int age;
        public float GPA;

        public Student()
        {
            Student_name = "George";
            Student_2name = "Isaac";
            age = 18;
            GPA = 4;

        }
        public override string ToString()
        {
            return Student_name + " " + Student_2name + " " + age + " " + GPA;

        }
    }
}
