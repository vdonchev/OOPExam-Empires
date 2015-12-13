namespace Empires.Interfaces
{
    using Models.Resources;

    public interface IResource
    {
        ResourceType Type { get; }

        int Quantity { get; }
    }
}