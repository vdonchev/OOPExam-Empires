namespace Empires.Interfaces.Engine
{
    public interface IOutputWriter
    {
        void Write(string line);

        void Flush();
    }
}