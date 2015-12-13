namespace Empires.Models.Units
{
    public class Swordsman : UnitBase
    {
        private const int SwordsmanDefaultHelath = 40;
        private const int SwordsmanDefaultDamage = 13;

        public Swordsman()
            : base(SwordsmanDefaultHelath, SwordsmanDefaultDamage)
        {
        }
    }
}