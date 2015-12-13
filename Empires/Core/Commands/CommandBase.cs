namespace Empires.Core.Commands
{
    using Interfaces.Engine;

    public abstract class CommandBase : ICommand
    {
        protected CommandBase(IEngine engine)
        {
            this.Engine = engine;
        }

        public IEngine Engine { get; }

        public abstract void Execute(string[] commandArgs);
    }
}