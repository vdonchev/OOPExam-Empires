namespace Empires.Core
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Interfaces.Engine;
    using Models.Resources;

    public class EmpiresDatabase : IDatabase
    {
        private readonly IList<IBuilding> buildings;
        private readonly IDictionary<string, IList<IUnit>> units;
        private readonly IDictionary<string, IList<IResource>> resouces;

        public EmpiresDatabase()
        {
            this.buildings = new List<IBuilding>();
            this.units = new Dictionary<string, IList<IUnit>>();
            this.resouces = InitilizeResources();
        }

        public IEnumerable<IBuilding> Buildings
        {
            get
            {
                return this.buildings;
            }
        }

        public IEnumerable<KeyValuePair<string, IList<IUnit>>> Units
        {
            get
            {
                return this.units;
            }
        }

        public IEnumerable<KeyValuePair<string, IList<IResource>>> Resources
        {
            get
            {
                return this.resouces;
            }
        }

        public void AddBuilding(IBuilding building)
        {
            this.buildings.Add(building);
        }

        public void AddUnit(IUnit unit)
        {
            string unitType = unit.GetType().Name;
            if (!this.units.ContainsKey(unitType))
            {
                this.units.Add(unitType, new List<IUnit>());
            }

            this.units[unitType].Add(unit);
        }

        public void AddResource(IResource resource)
        {
            string resourceName = resource.Type.ToString();
            this.resouces[resourceName].Add(resource);
        }

        private static Dictionary<string, IList<IResource>> InitilizeResources()
        {
            var resources = new Dictionary<string, IList<IResource>>();
            foreach (var resource in Enum.GetValues(typeof(ResourceType)))
            {
                resources.Add(resource.ToString(), new List<IResource>());
            }

            return resources;
        }
    }
}