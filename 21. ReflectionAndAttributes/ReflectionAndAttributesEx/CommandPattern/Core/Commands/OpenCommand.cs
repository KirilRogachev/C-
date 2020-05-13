namespace CommandPattern.Core.Commands
{
    using System.IO;
    using Contracts;
    using System;

    public class OpenCommand : ICommand
    {
        public string Execute(string[] args)
        {
            string path = args[0];
            System.Diagnostics.Process.Start("cmd", $"/c start {path}");
            return "Started successfully!";

        }
    }
}
