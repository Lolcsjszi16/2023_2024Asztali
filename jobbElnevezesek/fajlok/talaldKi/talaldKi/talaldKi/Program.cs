using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talaldKi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int teves = 0;
            int teves2 = 0;
            int ennyi = 0;
            int felhasznalo;
            Random rnd = new Random();
            int random = rnd.Next(0, 101);
            
            Console.WriteLine("Ebben a feladatban ki kell találnod egy számot!");
            

            do
            {
                Console.WriteLine("Adj meg egy számot a tippeléshez!");
                felhasznalo = Convert.ToInt32(Console.ReadLine());
                if (felhasznalo > random)
                {
                    Console.WriteLine("Ez a szám nagyobb mint a random szám");
                    teves++;
                    ennyi++;
                }
                if (felhasznalo < random)
                {
                    Console.WriteLine("Ez a szám kisebb mint a random szám");
                    ennyi++;
                    teves2++;
                }
                if (teves > 1)
                {
                    Console.WriteLine("Mondtam, hogy nagyobb.");
                    teves--;

                }
                if (teves2 > 1)
                {       
                    Console.WriteLine("Mondtam, hogy kisebb.");
                    teves2--;
                }
            }
            while (felhasznalo != random);

            Console.WriteLine("Ennyi találatból találtad ki:"+ ennyi);
            Console.ReadKey();
            
            

        }
    }
}
