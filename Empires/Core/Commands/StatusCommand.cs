namespace Empires.Core.Commands
{
    using System.Linq;
    using System.Text;
    using Interfaces.Engine;

    public class StatusCommand : CommandBase
    {
        public StatusCommand(IEngine engine)
            : base(engine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            var result = new StringBuilder();

            result.AppendLine("Treasury:");
            foreach (var resource in this.Engine.Db.Resources)
            {
                result.AppendLine($"--{resource.Key}: {resource.Value.Sum(t => t.Quantity)}");
            }

            result.AppendLine("Buildings:");
            if (this.Engine.Db.Buildings.Any())
            {
                foreach (var building in this.Engine.Db.Buildings)
                {
                    result.AppendLine(building.ToString());
                }
            }
            else
            {
                result.AppendLine("N/A");
            }

            result.AppendLine("Units:");
            if (this.Engine.Db.Units.Any())
            {
                foreach (var unit in this.Engine.Db.Units)
                {
                    result.AppendLine($"--{unit.Key}: {unit.Value.Count}");
                }
            }
            else
            {
                result.AppendLine("N/A");
            }

            this.Engine.OutputWriter.Write(result.ToString().Trim());
        }
    }
}