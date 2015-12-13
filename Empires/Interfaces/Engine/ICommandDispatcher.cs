namespace Empires.Interfaces.Engine
{
    public interface ICommandDispatcher
    {
        IEngine Engine { get; set; }

        void DispatchCommand(string[] commandArgs);

        void SeedCommands();
    }
}