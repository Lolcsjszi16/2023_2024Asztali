using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace oop { 
    class Program
    {
        static void Main()
        {

            ember Ann = new ember();
            ember Reb = new ember();
            ember Zoe = new ember();

            Ann.person = "Anita";
            Ann.nap = 25;
            Ann.ho = 10;
            Ann.ev = 2005;
            Ann.personalityTraits = "Shy";

            Reb.person = "Rebeka";
            Reb.nap = 22;
            Reb.ho = 04;
            Reb.ev = 2005;
            Reb.personalityTraits = "Loud, and loud.";

            Zoe.person = "Zoé";
            Zoe.nap = 25;
            Zoe.ho = 06;
            Zoe.ev = 2005;
            Zoe.personalityTraits = "Think she is funny.";

            Console.WriteLine("Embereink időségi sorrendben:" + Reb.person + ", " + Zoe.person + ", " + Ann.person);
            Console.WriteLine();
            Console.WriteLine("Lányok személyiségei:");
            Console.WriteLine(Reb.person + ": " + Reb.personalityTraits);
            Console.WriteLine(Zoe.person + ": " + Zoe.personalityTraits);
            Console.WriteLine(Ann.person + ": " + Ann.personalityTraits);
            Console.WriteLine();
            if (Zoe.ev<=Ann.ev && Zoe.ho<=Ann.ho&&Zoe.nap<=Ann.nap)
            {
                Console.WriteLine("Zoé idősebb mint Anita");
            }
            Console.ReadKey();
        }
    }

}
