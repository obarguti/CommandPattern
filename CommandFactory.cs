using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CommandPattern
{
    public class CommandFactory
    {
        private readonly List<Type> availableCommandTypes;

        public CommandFactory()
        {
            availableCommandTypes = new List<Type>();

            var iCommand = typeof (ICommand);
            var types = Assembly.GetExecutingAssembly().GetTypes();
            
            foreach (var type in types)
            {
                if (type.IsInterface || !iCommand.IsAssignableFrom(type))
                {
                    continue;
                }

                availableCommandTypes.Add(type);
            }
        }

        public ICommand GetCommand(string commandName, string argument)
        {
            var type = availableCommandTypes.SingleOrDefault(c => c.Name == commandName);

            if (type == null)
            {
                return new NullCommand();
            }

            return (ICommand) Activator.CreateInstance(type, argument ?? "");
        }
    }
}
