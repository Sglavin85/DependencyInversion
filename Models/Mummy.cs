using System;

namespace MonsterHunter
{
    public class Mummy : IMonster, ICombustable
    {
        public string name { get; set; }

        public Mummy(string Name)
        {
            name = Name;
        }
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine($"You stabbed {name} the Mummy... it flashes into a pile of ashes!");
            }
        }
    }
}