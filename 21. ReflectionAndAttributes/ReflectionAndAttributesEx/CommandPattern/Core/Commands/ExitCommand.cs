namespace CommandPattern.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Contracts;

    public class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
            Environment.Exit(0);
            return null;
        }
    }
}
