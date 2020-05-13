using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class StartUp
    {
        public static void Main()
        {
            var spy = new Spy();
            string result = spy.AnalyzeAcessModifiers("Hacker");
            Console.WriteLine(result);

        }
    }

