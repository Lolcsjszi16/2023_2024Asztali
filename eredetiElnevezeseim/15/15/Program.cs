using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ez a feladat 28számot randomizál 10 és -10 között, az adtott feltételekszerínt sorolja be őket!");
            int [] tomb= new int[28];
            int pozitiv = 0;
            int negativ = 0;
            int eredmeny = 0;
            int seven = 0;
            int hanyadik = 0;
            bool igaz=false;
            int legnagyobb = -10;
            int legkisebb = 10;
            Random rnd = new Random();
            Console.WriteLine("Randomizált számok: ");
            for (int i=0; i<28; i++)
            {
                
                int num = rnd.Next(-10, 11);
                tomb[i] = num;
                eredmeny=num%2;
                Console.Write(" "+ num + ",");
                if (eredmeny!=0)
                {
                    pozitiv++;
                }
                else
                {
                    negativ++;
                }
                if (num ==7)
                {
                    seven++;
                }
                if (tomb[i] == 0 && igaz == false)
                {
                    hanyadik = i; 
                    igaz = true;
                }
                
            }
            for (int i=0; i<28;i++)
            {
                if (legkisebb >= tomb[i])
                {
                    legkisebb = tomb[i];
                }
                if (legnagyobb <= tomb[i])
                {
                    legnagyobb = tomb[i];
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Legkisebb szám: "+ legkisebb + ", legnagyobb szám: "+legnagyobb+" hanyadik eleme nulla: "+ hanyadik + " hány elem hét: "+ seven);
            Console.WriteLine("Pozitív számok: " + pozitiv + ", negatív számok: " + negativ); 
            Console.ReadKey();

        }
    }
}
