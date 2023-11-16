using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace erettsegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ist<string> szavak = new List<string>();

            // Fájl beolvasása
            string[] lines = File.ReadAllLines("szavak.txt");
            foreach (string line in lines)
            {
                szavak.Add(line);
            }

            Random rnd = new Random();
            int rejtettSzoIndex = rnd.Next(szavak.Count);
            string rejtettSzo = szavak[rejtettSzoIndex];
            int betukSzama = 6; // A tippelendő betűk száma

            Console.WriteLine("Üdvözöljük a betűkitaláló játékban!");
            Console.WriteLine("A rejtett szó betűinek száma: " + betukSzama);

            int tippSzam = 0;
            string tipp = "";

            while (rejtettSzo.Length > 0 && tipp != "stop")
            {
                Console.Write("Tipp: ");
                tipp = Console.ReadLine().ToLower(); // Minden tippet kisbetűsre konvertálunk

                if (tipp == "stop")
                {
                    break;
                }

                if (tipp.Length != betukSzama)
                {
                    Console.WriteLine("A tippnek pontosan hatbetűsnek kell lennie!");
                    continue;
                }

                if (tipp == "eredmen")
                {
                    Console.WriteLine("Az összes lista elem:");
                    foreach (var szo in szavak)
                    {
                        Console.WriteLine(szo);
                    }
                    continue; // Ne folytassa a játékot
                }

                tippSzam++;

                string valasz = "";

                for (int i = 0; i < betukSzama; i++)
                {
                    if (rejtettSzo[i] == tipp[i])
                    {
                        valasz += rejtettSzo[i];
                    }
                    else
                    {
                        valasz += ".";
                    }
                }

                Console.WriteLine("Válasz: " + valasz);

                // Ellenőrizzük, hogy az összes betűt kitalálták-e
                if (valasz == rejtettSzo)
                {
                    Console.WriteLine("Gratulálok, kitaláltad a rejtett szót: " + rejtettSzo);
                    Console.WriteLine("Megfejtéshez használt tippek száma: " + tippSzam);
                    break;
                }
            }

            if (tipp == "stop")
            {
                Console.WriteLine("A játék leállítva.");
            }
            Console.ReadKey();
        }
    }
}