namespace Empires.Interfaces.Engine
{
    using System.Collections.Generic;

    public interface IDatabase
    {
        IEnumerable<IBuilding> Buildings { get; }

        IEnumerable<KeyValuePair<string, IList<IUnit>>> Units { get; }

        IEnumerable<KeyValuePair<string, IList<IResource>>> Resources { get; }

        void AddBuilding(IBuilding building);

        void AddUnit(IUnit unit);

        void AddResource(IResource resource);
    }
}