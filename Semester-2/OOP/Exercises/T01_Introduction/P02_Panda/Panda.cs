using System;
using System.Collections.Generic;
using System.Text;

namespace P02_PandaPopulation
{
    public class Panda
    {
        public Panda(string name)
        {
            this.Name = name;
            Population++;
        }

        public string Name { get; set; }

        private static int Population { get; set; }

        public string FavouriteFood()
        {
            return "Favourite food of the pandas is bamboo!";
        }

        public int GetPopulation()
        {
            return Population;
        }
    }
}
