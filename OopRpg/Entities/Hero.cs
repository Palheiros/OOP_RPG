namespace OopRpg.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Type { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public Hero()
        {
        }

        public Hero(string name, int level, string type, int hp, int mp)
        {
            Name = name;
            Level = level;
            Type = type;
            HP = hp;
            MP = mp;
        }

        public override string ToString()
        {
            return ($"Name:  {Name}\nLevel: {Level}\nType:  {Type}\nHP: {HP}\nMP: {MP}\n");
        }

        public virtual string Attack()
        {
            return ($"{Name} attacked with his sword!\n");
        }

        public virtual string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return ($"{Name} attacked with his sword with +{Bonus} and did a SUPER STRIKE!\n");
            }
            else
            {
                return ($"{Name} attacked with his sword with +{Bonus} bonus attack!\n");
            }
        }
    }
}
