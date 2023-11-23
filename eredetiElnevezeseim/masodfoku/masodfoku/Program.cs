using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodfoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Másodfokú egyetlen kiszámítása, add meg az első számot!");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Add meg a másik számot is !");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Add meg a harmadik számot is !");
            double c = Convert.ToDouble(Console.ReadLine());

            double masodikon = b * b;

            double gyokalatt = masodikon -( 4 * a * c);
            if (gyokalatt > 0)
            {
                gyokalatt = Math.Sqrt(gyokalatt);
                double erdemeny1 = (-b + gyokalatt) / 2 * a;
                double erdemeny2 = (-b - gyokalatt) / 2 * a;

                Console.WriteLine("Az első megoldás: x1 = {0:0.00}" , erdemeny1 );
                Console.WriteLine("A második megoldás: x2 = {0:0.00}", erdemeny2);

            }
            else
            {
                Console.WriteLine("Nem jó számokat adtál, meg. Győk alatt nem egész szám jött ki."+ masodikon + " " + gyokalatt);
            }
            
            Console.ReadKey();

        }
    }
}
