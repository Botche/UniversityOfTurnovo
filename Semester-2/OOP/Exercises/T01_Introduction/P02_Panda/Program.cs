using System;

namespace P02_PandaPopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Panda("'");
            var p1 = new Panda("'");
            Console.WriteLine(p.GetPopulation());

            var methods = p.GetType().GetMethods();

            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }
        }
    }
}
