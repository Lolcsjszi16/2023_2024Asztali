using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1109
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Ebben a játékban a dobokockákkal tudsz játszani!");
            Console.WriteLine("Hányat szeretnél dobni?");
            int valasz = Convert.ToInt32(Console.ReadLine());
            int Panni = 0;
            int Anni = 0;
            int osszeg = 0;
            for (int i = 0; i < valasz; i++)
            {
                int dobas1 = rnd.Next (0, 6);
                int dobas2 = rnd.Next(0, 6);
                int dobas3 = rnd.Next(0, 6);
                osszeg =dobas1 + dobas2 + dobas3;
                Console.WriteLine("  " + dobas1 +" + "+ dobas2 + " + " + dobas3 + " = " + osszeg);
                if (osszeg >= 10)
                {
                    Panni++;
                }
                if(osszeg <10) {
                    Anni++;
                }
            }

                Console.WriteLine("Ennyi alkalommal során Panni nyert: "+ Panni+" enniyszer Anni: "+ Anni);

            Console.ReadKey();

        }
    }
}
