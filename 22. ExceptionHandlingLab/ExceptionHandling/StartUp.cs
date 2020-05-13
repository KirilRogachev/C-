using System;

namespace SquareRoot
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                throw new ArgumentNullException("Invalid number");
            }
            else if (num < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid number");
            }
            else
            {
                try
                {
                    double result = Math.Sqrt(num);
                    Console.WriteLine(result);

                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex);
                }
                catch (ArgumentOutOfRangeException exc)
                {
                    Console.WriteLine(exc);
                }
                finally
                {
                    Console.WriteLine("Good bye!");
                }
            }
        }
    }
}
