namespace Empires.Core.Commands
{
    using Interfaces.Engine;

    public class EndCommand : CommandBase
    {
        public EndCommand(IEngine engine) 
            : base(engine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            this.Engine.Stop();
        }
    }
}