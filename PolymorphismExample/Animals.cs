using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    public class Animals
    {
        public static int PopulationCount;

        protected string _animalName;


        public Animals(string animalName)
        {
            _animalName = animalName;

            PopulationCount++;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("THIS IS IN THE BASE");
        }


    }
}