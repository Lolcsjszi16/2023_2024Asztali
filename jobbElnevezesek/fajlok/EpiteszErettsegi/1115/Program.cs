using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1115
{
    internal class Program
    {
        static int Ado(int adosav, int alapterulet)
        {
            int[] adok = { 800, 600, 100 };
            int fizetendo = adosav * alapterulet;
            if (fizetendo < 10000)
                return 0;
            else
                return fizetendo;
        }

        static void Main()
        {
            List<string> lines = File.ReadAllLines("utca.txt").ToList();
            int[] adosavok = lines[0].Split(' ').Select(int.Parse).ToArray();
            List<string[]> telekAdatok = lines.GetRange(1, lines.Count - 1).Select(line => line.Split(' ')).ToList();


            // 2. feladat: Hány telek adatai találhatók az állományban?
            Console.WriteLine($"2. feladat: {telekAdatok.Count} telek adatai találhatók az állományban.");

            // 3. feladat: Kérje be egy tulajdonos adószámát és írassa ki az épület adatait.
            Console.Write("3. feladat: Kérem, adjon meg egy tulajdonos adószámát: ");
            string tulajdonosAdoszam = Console.ReadLine();

            bool found = false;
            foreach (var adat in telekAdatok)
            {
                if (adat[0] == tulajdonosAdoszam)
                {
                    Console.WriteLine($"   Az épület adatai: {adat[1]} {adat[2]} {adat[3]} {adat[4]} m2");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("   Nem szerepel az adatállományban.");
            }

            // 4. feladat: Fizetendő adók számolása és kiíratása
            Dictionary<string, int> adosavokSum = new Dictionary<string, int> { { "A", 0 }, { "B", 0 }, { "C", 0 } };
            foreach (var adat in telekAdatok)
            {
                int adosavIndex = Array.IndexOf(new[] { "A", "B", "C" }, adat[3]);
                int adosav = adosavok[adosavIndex];
                int alapterulet = int.Parse(adat[4]);
                int fizetendo = Ado(adosav, alapterulet);
                adosavokSum[adat[3]] += fizetendo;
            }
            //5. feladat
            Console.WriteLine("5. feladat");
            foreach (var adosav in adosavokSum)
            {
                Console.WriteLine($"{adosav.Key}sáv:{telekAdatok.Count(adat => adat[3] == adosav.Key)} építmény, összesen {adosav.Value} Ft adó");
            }
            //6. feladat
            Console.WriteLine("6. feladat");
            var problemStreets = telekAdatok.GroupBy(adat => adat[1])
                                       .Where(group => group.Select(adat => adat[3]).Distinct().Count() > 1)
                                       .Select(group => group.Key)
                                       .ToList();
            foreach (var street in problemStreets)
            {
                Console.WriteLine($"{street} utcában felül kell vizsgálni a sávokba sorolást.");
            }
            //7. feladat
            using (StreamWriter writer = new StreamWriter("fizetendo.txt"))
            {
                Console.WriteLine("7. feladat:");
                foreach (var adat in telekAdatok.GroupBy(adat => adat[0]))
                {
                    string tulajdonosAdoszamAktualis = adat.Key;
                    int osszeg = adat.Sum(a => Ado(adosavok[Array.IndexOf(new[] { "A", "B", "C" }, a[3])], int.Parse(a[4])));
                    Console.WriteLine($"{tulajdonosAdoszamAktualis} {osszeg} Ft");
                    writer.WriteLine($"{tulajdonosAdoszamAktualis} {osszeg} Ft");
                }
            }

            Console.ReadLine();

        }

    }
}
