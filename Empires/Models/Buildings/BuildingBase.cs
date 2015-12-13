namespace Empires.Models.Buildings
{
    using System;
    using Core.Factories;
    using Core.Utils;
    using Interfaces;

    public abstract class BuildingBase : IBuilding
    {
        private const int TurnDelay = 1;

        protected BuildingBase(
            int turnsToProdUnit,
            int turnsToProdResource,
            string unitToProd,
            string resourceToProd,
            int resourceQuantity)
        {
            this.TurnsToProdUnit = turnsToProdUnit;
            this.TurnsToProdResource = turnsToProdResource;
            this.TurnsRemainToProdUnit = this.TurnsToProdUnit + TurnDelay;
            this.TurnsRemainToProdResource = this.TurnsToProdResource + TurnDelay;
            this.UnitToProd = unitToProd;
            this.ResourceToProd = resourceToProd;
            this.ResourceQuantity = resourceQuantity;
            this.TurnsPassed = 0 - TurnDelay;
        }

        public string UnitToProd { get; private set; }

        public string ResourceToProd { get; private set; }

        public bool CanProduceUnit
        {
            get
            {
                return this.TurnsRemainToProdUnit == 0;
            }
        }

        public bool CanProduceRecource
        {
            get
            {
                return this.TurnsRemainToProdResource == 0;
            }
        }

        protected int TurnsRemainToProdUnit { get; set; }

        protected int TurnsRemainToProdResource { get; set; }

        private int ResourceQuantity { get; set; }

        private int TurnsPassed { get; set; }

        private int TurnsToProdUnit { get; set; }

        private int TurnsToProdResource { get; set; }

        public virtual IUnit ProduceUnit()
        {
            if (!this.CanProduceUnit)
            {
                throw new InvalidOperationException(
                    string.Format(
                        EmpireConstants.CantProduceObject,
                        this.TurnsPassed,
                        this.GetType().Name,
                        this.UnitToProd,
                        this.TurnsRemainToProdUnit));
            }

            this.TurnsRemainToProdUnit = this.TurnsToProdUnit;
            return UnitFactory.Produce(this.UnitToProd);
        }

        public virtual IResource ProduceRecource()
        {
            if (!this.CanProduceRecource)
            {
                throw new InvalidOperationException(
                    string.Format(
                        EmpireConstants.CantProduceObject,
                        this.TurnsPassed,
                        this.GetType().Name,
                        this.ResourceToProd,
                        this.TurnsRemainToProdResource));
            }

            this.TurnsRemainToProdResource = this.TurnsToProdResource;
            return ResourceFactory.Produce(this.ResourceToProd, this.ResourceQuantity);
        }

        public virtual void MakeTurn()
        {
            this.TurnsPassed++;
            this.TurnsRemainToProdUnit--;
            this.TurnsRemainToProdResource--;
        }

        public override string ToString()
        {
            return $"--{this.GetType().Name}: {this.TurnsPassed} turns ({this.TurnsRemainToProdUnit} turns until {this.UnitToProd}, {this.TurnsRemainToProdResource} turns until {this.ResourceToProd})";
        }
    }
}