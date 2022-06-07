using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    public class Elephant : Animals
    {
        private string _elephantName;

        public Elephant( string elephantName ) : base( elephantName )
        {
            _elephantName = elephantName;
        }



        public override void MakeSound()
        {
            // Console.WriteLine(_animalName + " - Toot");

            string audioFileName = "c:\\animalsounds\\Elefant.mp3";


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
