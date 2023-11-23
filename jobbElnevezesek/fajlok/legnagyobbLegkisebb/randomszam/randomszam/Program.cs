using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomszam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ez a program A legnagyobb random számnak és a legkisebb randomszámnak a külömbségét számolja ki!");
            Console.WriteLine("Hány számot szeretnél randomizáni?");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Melyik legyen a legkisebb értéke?");
            int lk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Melyik legyen a legnagyobb értéke?");
            int ln = Convert.ToInt32(Console.ReadLine());

            int legn = lk;
            int legk = ln;
            Random rnd = new Random();
            int[] tomb = new int[n];
            Console.WriteLine(); Console.WriteLine("Ezzek a random számok: ");Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                
                tomb[i] = rnd.Next(lk, ln);
                Console.Write(" "+ tomb[i] +",");
            }
            int szamK = 0;
            int szamN = 0;
            for (int i = 0; i < n; i++)
            {
                if(tomb[i]>legn){
                    szamN = tomb[i];  
                    legn = tomb[i];
                }
                if(tomb[i]< legk)
                {
                    legk = tomb[i];
                    szamK =tomb[i];
                }
            }
            int eredmeny= szamN-szamK;
            Console.WriteLine(" ");
            Console.WriteLine("Ennyi a külömbsége a legnagyobb és a legkisebb között:"+ eredmeny+ ", legkisebbszám: " +szamK+ ", legnagyobb szám: "+szamN);
            Console.ReadLine();

        }
    }
}
