namespace Student
{
    internal class Student
    {
        private string firstName;
        private string lastName;
        private int gpa;
        private string studname;
        private string studlast;
        private double studgpa;

        public Student()
        {
            firstName = "firstName";
            lastName = "lastName";
            gpa = 0;
        }
       

        public Student(string studname, string studlast, double studgpa)
        {
            this.studname = studname;
            this.studlast = studlast;
            this.studgpa = studgpa;
        }

        public override string ToString()
        {
            return firstName + "_" + lastName + "_" + gpa;
        }
    }
}