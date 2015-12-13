namespace Empires.Core.Commands
{
    using Interfaces.Engine;

    public class SkipCommand : CommandBase
    {
        public SkipCommand(IEngine engine)
            : base(engine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            // no action required
        }
    }
}