using System;
using System.Collections.Generic;
using System.Text;

namespace P01_HumanConstruction.Humans
{
    public class Student:Human
    {
        public string FacultyNumber { get; set; }

        public Student(string name, int age, string facultyNumber) 
            : base(name, age)
        {
            FacultyNumber = facultyNumber;
        }

        public void Study()
        {
            Console.WriteLine($"{Name} with {FacultyNumber} is studing.");
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"My faculty number is {FacultyNumber}";
        }
    }
}
