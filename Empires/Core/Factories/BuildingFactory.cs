namespace Empires.Core.Factories
{
    using System;
    using Interfaces;
    using Models.Buildings;
    using Utils;

    public class BuildingFactory
    {
        public static IBuilding Produce(string buildingType)
        {
            switch (buildingType)
            {
                case "barracks":
                    return new Barracks();
                case "archery":
                    return new Archery();
                default:
                    throw new InvalidOperationException(
                        string.Format(EmpireConstants.NotExistingObj, "Building"));
            }
        }
    }
}