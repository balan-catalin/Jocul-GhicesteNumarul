using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhicesteNumarul
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int nr = rnd.Next(1, 128);
            bool tf = false;
            while (!tf)
            {
                Console.Write("Numarul tau este:");
                int x = int.Parse(Console.ReadLine());
                if (x < nr)
                    Console.WriteLine("Numarul tau este mai MIC decat numarul pe care trebuie sa il ghicesti.");
                else if (x > nr)
                    Console.WriteLine("Numarul tau este mai MARE decat numarul pe care trebuie sa il ghicesti.");
                else 
                    tf = true; 
            }
            Console.WriteLine("Felicitari, ai ghicit numarul " + nr);
            Console.WriteLine("Meriti un premiu");
        }
    }
}
