namespace Empires.Core
{
    using Exceptions;
    using Interfaces.Engine;

    public class EmpiresEngine : IEngine
    {
        private readonly IInputReader reader;
        private readonly IOutputWriter writer;
        private readonly ICommandDispatcher commandDispatcher;

        private bool isStarted;

        public EmpiresEngine(
            IInputReader reader,
            IOutputWriter writer,
            ICommandDispatcher commandDispatcher,
            IDatabase db)
        {
            this.writer = writer;
            this.reader = reader;
            this.commandDispatcher = commandDispatcher;
            this.commandDispatcher.Engine = this;
            this.Db = db;
        }

        public IDatabase Db { get; private set; }

        public IOutputWriter OutputWriter
        {
            get
            {
                return this.writer;
            }
        }

        public void Start()
        {
            this.commandDispatcher.SeedCommands();
            this.isStarted = true;

            while (this.isStarted)
            {
                string input = this.reader.ReadNextLine();
                string[] inputArgs = input.Split(' ');

                try
                {
                    this.commandDispatcher.DispatchCommand(inputArgs);
                }
                catch (EmpiresException ex)
                {
                    this.writer.Write(ex.Message);
                }

                this.DoTurn();
            }

            this.writer.Flush();
        }

        public void Stop()
        {
            this.isStarted = false;
        }

        private void DoTurn()
        {
            foreach (var building in this.Db.Buildings)
            {
                building.MakeTurn();
                if (building.CanProduceUnit)
                {
                    this.Db.AddUnit(building.ProduceUnit());
                }

                if (building.CanProduceRecource)
                {
                    this.Db.AddResource(building.ProduceRecource());
                }
            }
        }
    }
}