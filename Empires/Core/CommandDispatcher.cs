namespace Empires.Core
{
    using System;
    using System.Collections.Generic;
    using Commands;
    using Exceptions;
    using Interfaces.Engine;

    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IDictionary<string, ICommand> commandsByName;

        public CommandDispatcher()
        {
            this.commandsByName = new Dictionary<string, ICommand>();
        }

        public IEngine Engine { get; set; }

        public void DispatchCommand(string[] commandArgs)
        {
            string commandName = commandArgs[0];
            if (!this.commandsByName.ContainsKey(commandName))
            {
                throw new NotSupportedException(
                    "Command is not supported by engine");
            }

            var command = this.commandsByName[commandName];

            try
            {
                command.Execute(commandArgs);
            }
            catch (EmpiresException ex)
            {
                this.Engine.OutputWriter.Write(ex.Message);
            }
        }

        public void SeedCommands()
        {
            this.commandsByName["armistice"] = new EndCommand(this.Engine);
            this.commandsByName["build"] = new BuildCommand(this.Engine);
            this.commandsByName["skip"] = new SkipCommand(this.Engine);
            this.commandsByName["empire-status"] = new StatusCommand(this.Engine);
        }
    }
}