using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            //New up (instantiate) an isntance of your Greeter class inside Main method.  From this instance, call all the methods you've built.
            Greeter greeter = new Greeter();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            greeter.TakeNameSayHello(name);
            greeter.TakeNameSayBye(name);
            greeter.GreetByTimeOfDay();

        }
    }
}
