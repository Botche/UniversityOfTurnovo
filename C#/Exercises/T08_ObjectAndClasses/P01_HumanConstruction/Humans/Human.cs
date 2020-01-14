using System;
using System.Collections.Generic;
using System.Text;

namespace P01_HumanConstruction.Humans
{
    public abstract class Human
    {
        public string Name { get; set; }

        public int Age { get; set; }

        protected Human()
        {

        }

        protected Human(string name, int age):
            base()
        {
            Name = name;
            Age = age;
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} is walking...");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping...");
        }

        public void WhoAmI()
        {
            Console.WriteLine($"Everybody is asking...");
        }

        public override string ToString()
        {
            return $"I am {this.GetType().Name}. My name is {this.Name} and I am {this.Age} years old.";
        }
    }
}
