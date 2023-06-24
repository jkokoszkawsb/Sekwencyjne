using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile program ma wypisac liczb pierwszych");
            int iloscLiczbDoWypisania = int.Parse(Console.ReadLine());
            int iloscLiczbWypisanych = 0;

            for (int i = 2; iloscLiczbWypisanych < iloscLiczbDoWypisania; i++)
            {
                Boolean sprawdzenie = SprawdzPierwsza(i);
                if (sprawdzenie == true)
                {
                    Console.WriteLine(i);
                    iloscLiczbWypisanych++;
                }
                else
                {
                    continue;
                }
            }
            Console.ReadLine();
        }

        static Boolean SprawdzPierwsza(int n)
        {
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false; 
            return true;
        }
    }

}
