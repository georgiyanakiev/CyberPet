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
            Console.WriteLine("Hello! I am Your Cyber Pet!");
            synth.Speak("Hello! I am your Cyber Pet! Please press enter to continue");
            Console.ReadLine();

            string name, input;
            int age;
            Console.WriteLine("Please choose my name?");
            synth.Speak("Please choose my name?");
            name = Console.ReadLine();
            Console.WriteLine("Please choose my age?");
            synth.Speak("Please choose my age?");
            input = Console.ReadLine();
            age = Convert.ToInt32(input);
            Console.WriteLine("Hello, I am " + name + " and I am  " + age + " years old");
            synth.Speak("Hello, I am " + name + " and I am  " + age + " years old! Please press enter to continue");
            Console.ReadLine();
            Console.WriteLine("Please press 1 to feed me 2 to go to sleep or 3 for exit");
            synth.Speak("Please press 1 to feed me, 2 to go to sleep, or 3 for exit");
            Console.ReadLine();


            const string a = " You pressed 1";
            const string b = " You pressed 2";
            const string c = " You pressed 3";



            switch (input)
            {
                case "1":   
                    ShowData(a);        
                    Console.WriteLine("Going to Eat!");
                    Console.ReadLine();
                    break;

                case "2":   
                    ShowData(b);    
                    Console.WriteLine("Going to sleep!");
                    Console.ReadLine();
                    break;

                case "3":
                    ShowData(c);
                    Console.WriteLine("Exit");
                    Console.ReadLine();
                    break;


                default:
                    Console.WriteLine(" You did not type 1, 2 or 3");
                    synth.Speak(" You did not type 1, 2 or 3");
                    Console.WriteLine("Bye, Bye!");
                    synth.Speak("ByeBye!");
                    Console.ReadLine();
                    break;
            }
        }

        static void ShowData(string a)
        {
            Console.WriteLine(a);   //Changed from ShowData to a
        }

    }
}


        