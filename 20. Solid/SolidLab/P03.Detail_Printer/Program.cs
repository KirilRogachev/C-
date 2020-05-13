using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
              var employee = new Employee("Employee");
              var manager = new Manager("Manager", new[] { "Doc 1", "Doc 2", "Doc 3" });
              var handyMen = new HandyMen("HandyMen");
              var support = new Support("Support");


            var detailsPrinter = new List<Employee>();
            detailsPrinter.Add(employee);
            detailsPrinter.Add(manager);
            detailsPrinter.Add(handyMen);
            detailsPrinter.Add(support);

            foreach (var item in detailsPrinter)
            {
                Console.WriteLine(item);
            }
        }
    }
}
