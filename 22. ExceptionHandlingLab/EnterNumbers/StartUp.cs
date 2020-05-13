using System;

namespace EnterNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int count = 10;
            int num = 0;
            int[] numbers = new int[10];

            for (int i = 0; i < count; i++)
            {
                try
                {
                    num = ReadNumber(start, end);
                    start = num;
                    numbers[i] = num;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number");
                    
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The number is not in the requested range");
                    start = 1;
                    i = -1;
                    continue;
                }
            }
            
        }
        public static int ReadNumber(int start, int end)
        {
            Console.WriteLine($"Enter a number between {start} and {end}:");
            int num = int.Parse(Console.ReadLine());
            if(num<=start || num >= end)
            {
                throw new ArgumentException("The number is not in the requested range");
            }
            return num;
        }
    }
}
