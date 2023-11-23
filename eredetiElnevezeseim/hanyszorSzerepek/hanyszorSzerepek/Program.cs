using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hanyszorSzerepek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hány számot szeretnél, hogy sorsoljak?");
            int szam = Convert.ToInt32(Console.ReadLine());
            Random rnd= new Random();
            int[] tomb = new int[szam];
            for (int i = 0; i < szam; i++)
            {
                int num = rnd.Next(0,szam);
                tomb[i] = num;
            }
           

        }
    }
}
