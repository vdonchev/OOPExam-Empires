namespace Empires.Core.IO
{
    using System;
    using Interfaces.Engine;

    public class ConsoleReader : IInputReader
    {
        public string ReadNextLine()
        {
            return Console.ReadLine();
        }
    }
}