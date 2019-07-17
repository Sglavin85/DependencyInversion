using System;

namespace MonsterHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

            Mummy tuts = new Mummy("tuts");

            VonRimmersmark.Ignite(tuts);

        }
    }
}
