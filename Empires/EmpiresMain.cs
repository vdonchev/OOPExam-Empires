namespace Empires
{
    using Core;
    using Core.IO;
    using Interfaces.Engine;

    public static class EmpiresMain
    {
        public static void Main()
        {
            IInputReader consoleReader = new ConsoleReader();
            var consoleWriter = new ConsoleWriter
            {
                AutoFlush = true
            };

            ICommandDispatcher commandDispatcher = new CommandDispatcher();
            IDatabase database = new EmpiresDatabase();

            var engine = new EmpiresEngine(
                consoleReader,
                consoleWriter,
                commandDispatcher,
                database);

            engine.Start();
        }
    }
}