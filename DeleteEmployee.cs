using System;

namespace CommandPattern
{
    public class DeleteEmployee : ICommand
    {
        public string Name { get; set; }

        public DeleteEmployee(string name)
        {
            Name = name;
        }

        public void Execute()
        {
            Console.WriteLine("Deleting Employee {0}", Name);
        }
    }
}
