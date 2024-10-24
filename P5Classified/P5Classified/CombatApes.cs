using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class CombatApes : CombatAnimals
    {
        public void CanClimb()
        {
            Console.WriteLine($"{GetType().Name} can climb.");
        }
    }
    public class Chimpanzee : CombatApes
    {
        public void Properties()
        {
            CanClimb();
            IsAlive(250);
            CanBeUsedForCombatAlive(150);
            ItemDescription("small ape covered in black or brown hair");
        }
    }
    public class Gorilla : CombatApes
    {
        public void Properties()
        {
            CanClimb();
            IsAlive(450);
            CanBeUsedForCombatAlive(250);
            ItemDescription("large ape covered in black hair");
        }
    }
}
