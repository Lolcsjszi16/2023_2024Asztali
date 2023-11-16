using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Console.WriteLine("Ebben a feladat a listát neked kell feltölteni, de ha 0-lát adsz meg akkor vége van a listának!");
            int nulla = 0;
            int szamol=0;
            do
            {
                Console.WriteLine("Kérek egy számot a listában!");
                int szam = Convert.ToInt32(Console.ReadLine());
                if (szam == 0)
                {
                    nulla++;
                    break;
                }
                if (szam<0) { Console.WriteLine("Nem jó számot adtál meg!"); }

                szamol++;
                lista.Add(szam);

            }
            while (nulla <= 1);
            Console.WriteLine("Ezzek a lista elemei:");
            int szamolok = 1;
            foreach (int szam in lista)
            {
                
                if (szam > 0)
                {
                    Console.WriteLine("A lista eleme: " + szamolok+ ". és a szám:" + szam + ", ");
                    szamolok++;
                }
            }
            Console.ReadLine();
        }
    }
}
