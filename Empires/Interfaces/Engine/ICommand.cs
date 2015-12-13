namespace Empires.Interfaces.Engine
{
    public interface ICommand
    {
        IEngine Engine { get; }

        void Execute(string[] commandArgs);
    }
}