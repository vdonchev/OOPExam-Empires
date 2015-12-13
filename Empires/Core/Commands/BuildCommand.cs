namespace Empires.Core.Commands
{
    using Factories;
    using Interfaces;
    using Interfaces.Engine;

    public class BuildCommand : CommandBase
    {
        public BuildCommand(IEngine engine)
            : base(engine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string buildingType = commandArgs[1];
            IBuilding building = BuildingFactory.Produce(buildingType);
            this.Engine.Db.AddBuilding(building);
        }
    }
}