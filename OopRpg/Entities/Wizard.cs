namespace OopRpg.Entities
{
    internal class Wizard : Hero
    {
        public Wizard(string name, int level, string type, int hp, int mp) : base(name, level, type, hp, mp)
        {
        }

        public override string Attack()
        {
            return ($"{Name} casted a spell!\n");
        }

        public override string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return ($"{Name} casted a Super spell with +{Bonus} and did a Leviathan SUMMON!\n");
            }
            else
            {
                return ($"{Name} casted a strong spell with +{Bonus} bonus attack!\n");
            }
        }
    }
}
