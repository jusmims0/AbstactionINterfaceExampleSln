using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    public class Monkey : Animals
    {
        public Monkey(string animalName) : base(animalName)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Oooo Aaaah");
        }
    }
}
