namespace Empires.Interfaces.Engine
{
    public interface IEngine
    {
        IOutputWriter OutputWriter { get; }

        IDatabase Db { get; }

        void Start();

        void Stop();
    }
}