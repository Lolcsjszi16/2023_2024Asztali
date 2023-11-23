using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double OsszSuly = 0;
            int nagyobb =0;
            int nagySuly = 0;
            int kettoN = 0;
            int negyvenAl =0;
            double legk =250;
            double legn =0;

            Console.WriteLine("Ez a program a halaknak a hosszát, és magasságát tárolja! És egyébb feltételek szerint besorolja őket!");

            double[] suly = new double[14];
            double[] hosszu = new double[14];
            Random rnd = new Random();

            for (int i = 0; i < 14; i++)
            {
                int num = rnd.Next(0, 251);
                int n = rnd.Next(0, 251);
                suly[i] = num;
                hosszu[i] = n;
                OsszSuly = OsszSuly + suly[i];
                if (2 <=suly[i])kettoN++;
                if (70 < suly[i]) nagyobb++;
                if (50 < suly[i] && 28 < hosszu[i]) nagySuly++;
                if (40 > suly[i]) negyvenAl++;
                Console.Write(" "+ suly[i]+"dkg,");
            }
            int szam = 0;
            do
            {
                if (suly[szam]<legk)
                {
                legk =+ suly[szam];
                }
                if (suly[szam]> legn)
                {
                legn = +suly[szam];
                }
                szam++;
            }
            while (szam!=14);

            Console.WriteLine(" "); Console.WriteLine(" ");
            Console.WriteLine("Ezzek az adatok: ");
            Console.WriteLine("Az Össz súly: "+ OsszSuly+", Legnagyobb súly:  "+legn+", Legkisebb súly: "+ legk+", 70dkg nagyobb: "+ nagyobb+ ", NagySuly 2 feltételnek felel meg: "+ nagySuly+ ", Kettőnél nagyobb: "+ kettoN+ ", 40 Alatt van: "+ negyvenAl);
            Console.ReadKey();

        }
    }
}
