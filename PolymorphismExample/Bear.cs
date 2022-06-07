using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    public class Bear : Animals
    {
        public Bear(string animalName) : base(animalName)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(_animalName + "growl");
        }
    }
}



