using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm myFarm = new Farm() { [1] = "cat", [3] = "bird", [5] = "dog" };
            myFarm[2] = "rabbit";
            myFarm[7] = "turtle";

            myFarm[100] = "pinguin";

            for (int i = 0; i < myFarm.GetNumberAnimals(); i++)
            {
                Console.WriteLine("Animal[{0}]={1}",i, myFarm[i]??"empty");
            }
            Console.WriteLine();
        }
    }
}
