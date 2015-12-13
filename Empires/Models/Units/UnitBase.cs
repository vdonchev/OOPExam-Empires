namespace Empires.Models.Units
{
    using Core.Utils;
    using Interfaces;

    public abstract class UnitBase : IUnit
    {
        private int health;
        private int attackDamage;

        protected UnitBase(int health, int attackDamage)
        {
            this.Health = health;
            this.AttackDamage = attackDamage;
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                Validator.IsBiggerThan(value, 0, "Health");
                this.health = value;
            }
        }

        public int AttackDamage
        {
            get
            {
                return this.attackDamage;
            }

            protected set
            {
                Validator.IsBiggerThan(value, 0, "Attack damage", true);
                this.attackDamage = value;
            }
        }

        public void SetHealth()
        {
            if (this.Health < 0)
            {
                this.health = 0;
            }
        }
    }
}