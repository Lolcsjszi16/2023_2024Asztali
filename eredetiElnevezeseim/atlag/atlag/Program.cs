using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ez a feladat a diákoknak az átlagját tárolja!");
            Console.WriteLine("Hány diáknak a jegyét szeretnéd tárolni?");
            int diak = Convert.ToInt32(Console.ReadLine()); // Konvertáljuk int típussá azt, hogy hány diák lesz összesen
            double[] jegyek = new double[diak]; // tömb a jegyeknek, és annyi jegy lesz amennyi diák van
            
            double atlag = 0; //Osztály átlagot számolja
            double atlagN = 0; // átlagnál Nagyobbakat tárolja
            
            for (int i = 0; i < diak; i++)
            {
                Console.WriteLine("Hányas lett az értékelése"); 
                double jegy = Convert.ToDouble(Console.ReadLine());
                jegyek[i] = jegy; // jegyek[i] tömbnek - azt az értéket adja meg amit a felhaszáló beírt
                atlag = atlag+ jegy; // hozzá adja az átlaghoz a jegyet, de nem értéket ad neki
            }
            double eredmeny = atlag / diak; // erdeményben tárolja az atlag az össz létszám a diák pedig a diákok száma
            for(int i = 0; i < diak; i++) // cíklus, hogy a tömb elemeit elemezze, hogy nagyobbak-e az átlagnál
            {
                if (eredmeny < jegyek[i]) 
                {
                    atlagN++; //Növeli az értékét
                }
            }
            Console.WriteLine("Ennyi az átlag: {0:0.00}, ", eredmeny);
            Console.WriteLine("Ennyi diák lett annál jobb: ", atlagN);
            Console.ReadLine();
        }
    }
}
