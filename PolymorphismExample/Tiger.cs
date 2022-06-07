using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    public class Tiger : Animals
    {
        public Tiger(string animalName) : base(animalName)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(_animalName + " - Purrr");

            string audioFileName = "c:\\animalsounds\\Tiger.mp3";


            using (var audioFile = new AudioFileReader(audioFileName))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);

                }

            }
        }
    }
}
