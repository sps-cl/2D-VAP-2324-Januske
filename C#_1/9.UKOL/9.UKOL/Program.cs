using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Uvod
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Zadej sekvence čisel");
                string text = Console.ReadLine();
                string[] hodnoty = text.Split(',');
                int[] cisla = new int[hodnoty.Length];
                bool chyba = false;
                for (int i = 0; i < cisla.Length; i++)
                {
                    if (!int.TryParse(hodnoty[i], out cisla[i]))
                    {
                        chyba = true;
                        break;
                    };
                }
                if (chyba)
                {
                    Console.WriteLine("Neplatny vstup.");
                    Console.ReadLine();
                    continue;
                }
                int min = cisla[0];
                for (int i = 1; i < cisla.Length; i++)
                {
                    if (cisla[i] < min)
                    {
                        min = cisla[i];
                    }
                }

                int max = cisla[0];
                for(int i = 1;i < cisla.Length; i++)
                {
                    if (cisla[i] > max)
                    {
                        max = cisla[i]; 
                    }
                }

                int maxLength = 1;
                int currentLength = 1;
                for (int i = 1; i < cisla.Length; i++)
                {
                    if (cisla[i] > cisla[i - 1])
                    {
                        currentLength++;
                        if (currentLength > maxLength)
                            maxLength = currentLength;
                    }
                    else
                    {
                        currentLength = 1;
                    }
                }

                Console.WriteLine($"Nejmenší číslo je {min}.");
                Console.WriteLine($"Největší číslo je {max}.");
                Console.WriteLine($"Délka nejdelšího vzestupného intervalu je {maxLength}.");
                Console.ReadLine();

            }
            
            
        }
    }

}