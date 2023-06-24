using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class zad3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wysokość trójkąta");
            int wysokosc = int.Parse(Console.ReadLine());
            int maxSzerokosc = 4 * wysokosc - 1;

            for (int i = 1; i <= wysokosc; i++)
            {
                int obecnaSzerokosc = 4 * i - 3;
                int liczbaSpacjiPrzedPlusem = (maxSzerokosc - obecnaSzerokosc) / 2;
                
                for (int j = 0; j < liczbaSpacjiPrzedPlusem; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < obecnaSzerokosc; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
