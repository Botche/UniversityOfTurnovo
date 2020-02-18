using System;
using System.Collections.Generic;
using System.Text;

namespace P01_HumanConstruction.Humans
{
    public class Teacher:Human
    {
        public Teacher(string name, int age)
            : base(name, age)
        {
        }

        public void Teach()
        {
            Console.WriteLine("Teaching students");
        }
    }
}
