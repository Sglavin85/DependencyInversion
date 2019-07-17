using System;

namespace MonsterHunter
{
    public class Wight : IMonster, ISilverable
    {
        public string name { get; set; }

        public Wight(string Name)
        {
            name = Name;
        }

        public void Stab(string attack)
        {
            if (attack == "Silver")
            {
                Console.WriteLine($"You stabbed {name} the Wight and he dead!");
            }
        }
    }
}