using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class WeaponsTwoHand : Weapons
    {
        public void CanBeTwohanded()
        {
            Console.WriteLine($"{GetType().Name} is wielded in both hands.");
        }
    }
    public class Spear : WeaponsTwoHand
    {
        public void Properties()
        {
            Damage(false, "", 150);
            ItemDescription("made from a wooden shaft with a small metal head");
        }
    }
}
