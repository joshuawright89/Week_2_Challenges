using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2_Challenges
{
    class Greeter
    {
        //"Build a class called Greeter.  This will hold our next few methods."
        //[[[Done ^^^]]]

        //Inside this new class, build method that takes in a name and outputs (to the console) hello to that person
        public void TakeNameSayHello(string name)
        {
            Console.WriteLine($"Hello there, + {name}!");
        }

        //Build another method that takes a name and outputs a farewell to that person
        public void TakeNameSayBye(string name)
        {
            Console.WriteLine($"Goodbye, {name}.");
        }

        //Build a method that outputs, depending on time of day:
        //a. "Good morning"
        //b. "Good afternoon"
        //c. "Good evening"
        //d. "Good night"

        public void TimeOfDay()
        {
            int timeOfDay = DateTime.Now.Hour;

            if (timeOfDay >= 0 && timeOfDay < 12)
            {
                Console.WriteLine("Good morning!");
            }
            else if (timeOfDay >= 12 && timeOfDay < 18)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if (timeOfDay >= 18 && timeOfDay < 21)
            {
                Console.WriteLine("Good evening.");
            }
            else
            {
                Console.WriteLine("Nighty night, don't let the bed bugs give you HIV.");
            }



        }



    }
}
