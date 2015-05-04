using System;

namespace CommandPattern
{
    public class AddEmployee : ICommand
    {
        public string Name { get; set; }

        public AddEmployee(string name)
        {
            Name = name;
        }

        public void Execute()
        {
            Console.WriteLine("Adding Employee {0}", Name);
        }
    }
}
