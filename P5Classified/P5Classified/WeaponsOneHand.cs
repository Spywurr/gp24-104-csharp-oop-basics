using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class WeaponsOneHand : Weapons
    {
        public void CanBeSinglehanded()
        {
            Console.WriteLine($"{GetType().Name} can be held in one hand.");

            
        }

    }
    public class Axe : WeaponsOneHand
    {
        public void Properties()
        {
            Damage(true, "can be used to chop wood.", 250);
            ItemDescription("made from a wooden shaft and has a metallic head");

        }
    }
    public class Sword : WeaponsOneHand
    {
        public void Properties()
        {
            Damage(false, "", 150);
            ItemDescription("made from a light-brown leather hilt and a metal blade");
        }
    }
}
