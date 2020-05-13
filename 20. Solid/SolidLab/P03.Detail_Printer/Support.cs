
using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    class Support : Employee
    {
        public Support(string name)
            : base(name)
        {
        }

        public override string ToString()
        {
            return $"{this.Name} last";
        }
    }
}
