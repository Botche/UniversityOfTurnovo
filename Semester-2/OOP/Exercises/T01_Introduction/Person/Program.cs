namespace P03_Person
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Pesho", "Petrov", new DateTime(1997, 04, 11));
            Console.WriteLine(person);
        }
    }
}
