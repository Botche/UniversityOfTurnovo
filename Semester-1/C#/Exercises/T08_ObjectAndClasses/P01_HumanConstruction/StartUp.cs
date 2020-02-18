using System;
using P01_HumanConstruction.Humans;

namespace P01_HumanConstruction
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var firstStudent = new Student("Ivan", 12, "12435135");
            var secondStudent = new Student("Gosho", 16, "2131235135");

            Console.WriteLine(firstStudent.ToString());
            Console.WriteLine(secondStudent.ToString());

            var teacher = new Teacher("Peter", 30);
            Console.WriteLine(teacher.ToString());
        }
    }
}
