using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
   public class Zoo
    {
        List<Animals> _animals = new List<Animals>();

        


        public Zoo ()
        {
            // Creating Elephant

            Elephant elephant = new Elephant ("Dumbo");
            _animals.Add (elephant);

            elephant = new Elephant ("Bambi");
            _animals.Add(elephant);

            elephant = new Elephant("Angel");
            _animals.Add(elephant);

            // Creating Monkey 

            Monkey monkey = new Monkey("George");
            _animals.Add(monkey);

            Monkey anothermonkey = new Monkey("Britney");
            _animals.Add(monkey);

            anothermonkey = new Monkey("Britney 1");

            anothermonkey = new Monkey("Britney 2");

            anothermonkey = new Monkey("Britney 3");

            anothermonkey = new Monkey("Britney 4");

            anothermonkey = new Monkey("Britney 5");


            // Creating a Tiger

            Tiger tiger = new Tiger("Aquila");
            _animals.Add(tiger);

            // Creating a Bear

            Bear bear = new Bear ("Wouter");
            _animals.Add(bear);

        }

        public int GetPopulationOfAnimals()
        {
            return Animals.PopulationCount;  
        }



        public void PerformShowWithAllAnimals()
        {
            // Loop to run through group of elephants calling name + sound

            foreach (Animals animals in _animals)
            {

                Console.WriteLine ("POP"+ Animals.PopulationCount);
                animals.MakeSound();

            }

        }






    }
}
