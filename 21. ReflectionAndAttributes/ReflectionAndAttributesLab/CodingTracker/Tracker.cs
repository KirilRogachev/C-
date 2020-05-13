    using CodingTracker;
    using System;
    using System.Linq;
    using System.Reflection;
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            var type = typeof(StartUp);

            MemberInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

            foreach (var method in methods)
            {
                var attributes = method.GetCustomAttributes<AuthorAttribute>();
                foreach (var attr in attributes)
                {
                    Console.WriteLine($"{method.Name} is written by {attr.Name}");
                }
                
            }
        }
    }

