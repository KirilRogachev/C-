﻿using System;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                var tokens = command.Split();

                switch (tokens[0])
                {
                    case "Create":
                        listyIterator = new ListyIterator<string>(tokens.Skip(1).ToArray());
                        break;
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "Print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (InvalidOperationException ioe)
                        {
                            Console.WriteLine(ioe.Message);
                        }
                        break;
                    case "PrintAll":
                        try
                        {
                            Console.WriteLine(string.Join(" ", listyIterator));
                        }
                        catch (InvalidOperationException ioe)
                        {
                            Console.WriteLine(ioe.Message);
                        }
                        
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    default:
                        throw new ArgumentException();
                }


            }
        }
    }
}
