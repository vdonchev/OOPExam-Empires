namespace Empires.Models.Buildings
{
    public class Barracks : BuildingBase
    {
        private const int DefaultTurnsToProdUnit = 4;
        private const int DefaultTurnsToProdResource = 3;
        private const string DefaultUnitToProd = "Swordsman";
        private const string DefaultResourceToProd = "Steel";
        private const int DefaultResourceQuntity = 10;

        public Barracks(
            int turnsToProdUnit = DefaultTurnsToProdUnit,
            int turnsToProdResource = DefaultTurnsToProdResource,
            string unitToProd = DefaultUnitToProd,
            string resourceToProd = DefaultResourceToProd,
            int resourceQuantity = DefaultResourceQuntity)
            : base(
                  turnsToProdUnit,
                  turnsToProdResource,
                  unitToProd,
                  resourceToProd,
                  resourceQuantity)
        {
        }
    }
}