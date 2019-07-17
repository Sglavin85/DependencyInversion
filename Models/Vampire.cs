using System;

namespace MonsterHunter
{
    public class Vampire : IMonster, ISilverable, ICombustable
    {
        public string name { get; set; }

        public Vampire(string Name)
        {
            name = Name;
        }
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine($"You Lit {name} the Vampire and he is crispy AF!");
            }
        }

        public void Stab(string attack)
        {
            if (attack == "Silver")
            {
                Console.WriteLine($"You stabbed {name} the Vampire and he gone!");
            }
        }
    }
}