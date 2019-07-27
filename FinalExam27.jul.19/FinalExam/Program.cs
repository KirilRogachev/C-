using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalExam
{
    class Program
    {
        static void AddGrup(string grup, List<string> Names
            , Dictionary<string, List<string>> addMet)
        {
            if (!addMet.ContainsKey(grup))
            {
                addMet.Add(grup, new List<string>());
            }

            foreach (var some in Names)
            {
                if(!addMet[grup].Contains(some))
                {
                addMet[grup].Add(some);
                }
            }
        }
        static void PlayGrup(string grup, int timeMte, Dictionary<string,int> playMet)
        {
            if(!playMet.ContainsKey(grup))
            {
                playMet.Add(grup, 0);
            }
            playMet[grup] += timeMte;
        }
        static void Main(string[] args)
        {
            string comand = "";
            var add = new Dictionary<string, List<string>>();
            var play = new Dictionary<string, int>();

            while ((comand = Console.ReadLine()) != "start of concert")
            {
                string[] comandSplit = comand
                    .Split("; ")
                    .ToArray();

                if (comandSplit[0] == "Add")
                {
                    List<string> listNames = comandSplit[2]
                    .Split(", ")
                    .ToList();
                    AddGrup(comandSplit[1], listNames, add);
                }
                else if (comandSplit[0] == "Play")
                {
                    int time = int.Parse(comandSplit[2]);
                    PlayGrup(comandSplit[1],time, play);
                        
                }
            }
            string printGrup = Console.ReadLine();
            int sum = 0;
            foreach (var x in play)
            {
                sum += x.Value;
            }
            Console.WriteLine($"Total time: {sum}");
           play = play.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var y in play)
            {
                Console.WriteLine($"{y.Key} -> {y.Value}");
            }
          
            foreach (var z in add)
            {
                if (z.Key == printGrup)
                {
                    Console.WriteLine(z.Key);
                    foreach (var p in z.Value)
                    {
                        Console.WriteLine($"=> {p}");
                    }
                }
            }

        }
    }
}