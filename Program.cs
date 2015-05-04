using System;

namespace CommandPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                PrintUsage();
                return;
            }

            var commandFactory = new CommandFactory();
            var command = commandFactory.GetCommand(args[0], args[1]);

            command.Execute();
        }

        private static void PrintUsage()
        {
            Console.WriteLine("Usage: CommandPattern.exe Command Arguments");
            Console.WriteLine("Available Commands: ");
            Console.WriteLine("     AddEmployee");
            Console.WriteLine("     DeleteEmployee");
        }
    }
}
