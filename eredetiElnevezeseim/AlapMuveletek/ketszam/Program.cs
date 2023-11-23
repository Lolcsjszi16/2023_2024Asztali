using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ketszam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ez a feladatnál két szám megadásával, végezhetsz alapműveleteket!");
            double eredmeny = 0;
            
            Console.WriteLine("Adj meg egy számot!");
            double szam1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adj meg egy másik számot!");
            double szam2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Akarsz ezzel a két számmal számolni?(igen,nem válasszal)");
            string valasz = Convert.ToString(Console.ReadLine());
            if (valasz == "igen")
            {
                Console.WriteLine("Összeadást, kivonást, szorzást vagy osztást szeretnél?(+,-,*,/ jelöld válaszodban!)");
                string szamolas = Convert.ToString(Console.ReadLine());
                bool folytatni = true;
                while (folytatni == true) { 
                    switch (szamolas)
                    {
                        case "+":
                            eredmeny = szam1 + szam2;
                            Console.WriteLine("Ennyi lett az erdeményed:"+ eredmeny);
                            break;

                        case "-":
                            eredmeny = szam1 - szam2;
                            Console.Write("Ennyi lett az erdeményed:"+ eredmeny);
                            break;

                        case "*":
                            eredmeny = szam1 * szam2;
                            Console.Write("Ennyi lett az erdeményed:" + eredmeny);
                            break;

                        case "/":
                            eredmeny = szam1 / szam2;
                            Console.Write("Ennyi lett az erdeményed:"+ eredmeny);
                            break;
                    }
                Console.WriteLine("Szeretnél még számolni?(igen,nem válasszal)");
                string valasz5 = Convert.ToString(Console.ReadLine());
                if (valasz5 == "nem") folytatni = false;
                }
            }
            else
            {
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
