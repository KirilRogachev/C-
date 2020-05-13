namespace CommandPattern.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Contracts;

   public class HelloCommand : ICommand
    {
        public string Execute(string[] args)
        {
            string name = args[0];
            return $"Hello, {name}";
        }
    }
}
