using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Student
{
    public class Student
    {
        public Student()
        {

        }

        public Student(string firstName, string lastName, int age)
            : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string PrintStudent()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"--FirstName: {this.FirstName}")
                .AppendLine($"--LastName: {this.LastName}")
                .AppendLine($"--Age: {this.Age}");

            return sb.ToString();
        }
    }
}
