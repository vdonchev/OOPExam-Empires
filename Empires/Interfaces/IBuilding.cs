namespace Empires.Interfaces
{
    public interface IBuilding
    {
        bool CanProduceUnit { get; }

        bool CanProduceRecource { get; }

        IUnit ProduceUnit();

        IResource ProduceRecource();

        void MakeTurn();
    }
}