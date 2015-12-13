namespace Empires.Models.Buildings
{
    public class Archery : BuildingBase
    {
        private const int DefaultTurnsToProdUnit = 3;
        private const int DefaultTurnsToProdResource = 2;
        private const string DefaultUnitToProd = "Archer";
        private const string DefaultResourceToProd = "Gold";
        private const int DefaultResourceQuntity = 5;

        public Archery(
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