using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    class Farm
    {
		//declare an array to store the data elements.
        private string[] animals = new string[10];
		//indexer -  allows instances of a class or struct to be indexed just like arrays
        public string this[int number]
        {
            get
            {
                if (number >= 0 && number < animals.Length)
                {
                    return animals[number];
                }
                return "Error";
            }
            set
            {
                if (number >= 0 && number < animals.Length && !string.IsNullOrEmpty(value))
                {
                    animals[number] = value;
                }                    
            }
        }
        public int GetNumberAnimals()
        {
            return animals.Length;
        }
    }
}
