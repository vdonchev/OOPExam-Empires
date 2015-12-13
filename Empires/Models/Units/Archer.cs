namespace Empires.Models.Units
{
    public class Archer : UnitBase
    {
        private const int ArcherDefaultHelath = 25;
        private const int ArcherDefaultDamage = 7;

        public Archer()
            : base(ArcherDefaultHelath, ArcherDefaultDamage)
        {
        }
    }
}