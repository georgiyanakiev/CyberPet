using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace CyberPet
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello! I am your Cyber Pet! Please press enter to continue");
            Console.WriteLine("Hello! I am Your Cyber Pet!");
            Console.ReadLine();

            string name, input;
            int age;
            Console.WriteLine("What is your name?");
            synth.Speak("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            synth.Speak("What is your age?");
            input = Console.ReadLine();
            age = Convert.ToInt32(input);
            Console.WriteLine("Hello " + name + " you are " + age + " years old");
            synth.Speak("Hello " + name + " you are " + age + " years old");
            Console.ReadLine();

        }
    }
}
