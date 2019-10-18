using System;

namespace myApp
{
    class Student
    {
        private string name;
        private string major;
        private double gpa;


        public Student(string name, string major, double gpa)
        {
            this.name = name;
            this.major = major;
            this.gpa = gpa;
        }

        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length >= 10)
                {
                    value = name;
                }
                else if (value.Length < 5)
                {
                    Console.WriteLine("Name is short");
                }

            }
        }
    }
}