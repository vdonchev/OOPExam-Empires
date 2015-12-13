namespace Empires.Core.Factories
{
    using System;
    using Interfaces;
    using Models.Units;
    using Utils;

    public static class UnitFactory
    {
        public static IUnit Produce(string unitType)
        {
            switch (unitType)
            {
                case "Swordsman":
                    return new Swordsman();
                case "Archer":
                    return new Archer();
                default:
                    throw new InvalidOperationException(
                        string.Format(EmpireConstants.NotExistingObj, "Unit"));
            }
        }
    }
}