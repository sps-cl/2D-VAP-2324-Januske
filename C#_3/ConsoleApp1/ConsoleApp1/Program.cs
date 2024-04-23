using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int index = 0;

            while (true)
            {
                Console.Write("Zadejte příkaz:");
                string input = Console.ReadLine();

                if (input.StartsWith("Pridat."))
                {
                    string wordA = input.Substring(7).Trim();
                    list.Add(wordA);
                    index = list.Count - 1;
                    Console.WriteLine($"Slovo '{wordA} bylo přidáno'");

                }
                else if (input == "Zpet")
                {
                    if (index >= 0)
                    {
                        Console.WriteLine($"Předchozí slovo: '{list[index]}'");
                        index--;
                        
                    }
                    else
                    {
                        Console.WriteLine("Ždáné přechozí slovov není k dispozici");
                    };

                }
                else if (input == "Vpred")
                {
                    if (index < list.Count - 1)
                    {
                        index++;
                        Console.WriteLine($"Následují slovo: '{list[index]} ");
                    }
                    else
                    {
                        Console.WriteLine("Ždáné přechozí slovov není k dispozici");
                    }
                }
                else
                {
                    Console.WriteLine("Neznámý příkaz. Použijte 'Pridat:', 'Zpet' nebo 'Vpred'.");
                }
            }
            
        }
    }
}
