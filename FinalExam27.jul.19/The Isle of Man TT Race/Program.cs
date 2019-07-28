using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string patters = @"([#$%*&])(?<name>[A-z]+)(\1)=(?<lenght>\d+)!!(?<code>.+)";

            string input = Console.ReadLine();
            while (true)
            {
                Regex order = new Regex(patters);
                if(order.IsMatch(input))
                {
                    string name = order.Match(input).Groups["name"].Value;
                    int lenght = int.Parse(order.Match(input).Groups["lenght"].Value);
                    string code = order.Match(input).Groups["code"].Value;
                    if(lenght==code.Length)
                    {
                        StringBuilder codee = new StringBuilder();
                        for (int i = 0; i < code.Length; i++)
                        {
                            char simbol = (char)(code[i] + lenght);
                            codee.Append(simbol);

                        }
                        Console.WriteLine($"Coordinates found! {name} -> {codee}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Nothing found!");
                    }

                }
                else
                {
                    Console.WriteLine($"Nothing found!");
                }
                input = Console.ReadLine();
            }
        }
    }
}