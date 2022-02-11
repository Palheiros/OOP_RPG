namespace OopRpg.Entities
{
    internal class Ninja : Hero
    {
        public Ninja(string name, int level, string type, int hp, int mp) : base(name, level, type, hp, mp)
        {
        }

        public override string Attack()
        {
            return ($"{Name} attacked with a katana!\n");
        }

        public override string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return ($"{Name} casted a Super spell with +{Bonus} and summoned a Fire Dragon!\n");
            }
            else
            {
                return ($"{Name} casted a lighting shuriken with +{Bonus} bonus attack!\n");
            }
        }
    }
}
