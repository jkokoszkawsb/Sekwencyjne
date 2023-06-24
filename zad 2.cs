using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int iloscliczb = 10;
            int liczbalosowan = 0;
            Console.WriteLine("Wybierz wersje programu: 1 - sprawdza, czy liczba jest parzysta po wylosowaniu, 2 - losuje od razu liczbę parzystą");
            int wersja = int.Parse(Console.ReadLine());
            if (wersja == 1)
            {
                for (int i = 0; i < iloscliczb; i++)
                {
                    int wylosowanaliczba;
                    do
                    {
                        wylosowanaliczba = random.Next(-8, 9);
                        liczbalosowan++;
                    } while (wylosowanaliczba % 2 != 0);

                    Console.Write(wylosowanaliczba);

                    if (i < liczbalosowan - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("Liczba wykonanych losowań: " + liczbalosowan);
                Console.ReadLine();
                
            }
            else if (wersja == 2)
            {
                for (int i = 0; i < iloscliczb; i++)
                {
                    int wylosowanaLiczba = random.Next(-4, 5) * 2;
                    liczbalosowan++;

                    Console.Write(wylosowanaLiczba);

                    if (i < iloscliczb - 1)
                    {
                        Console.Write(", ");
                    }
                }

            
                Console.WriteLine("Liczba wykonanych losowań: " + liczbalosowan);
                Console.ReadLine();
            }
        }
    }
}
