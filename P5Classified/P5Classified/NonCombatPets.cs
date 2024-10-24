using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class NonCombatPets : AnimateObjects
    {
        public void CanFly()
        {
            Console.WriteLine($"{GetType().Name} can fly.");
        }
        public void CanBeUsedNonCombat(string Usage)
        {
            Console.WriteLine($"{GetType().Name} can be used for {Usage}.");
        }
    }
    public class Pigeon : NonCombatPets
    {
        public void Properties()
        {
            IsAlive(25);
            CanFly();
            CanBeUsedNonCombat("sending messages.");
            ItemDescription("a medium sized bird with gray feathers");
        }
    }
    public class Sparrow : NonCombatPets
    {
        public void Properties()
        {
            
            CanFly();
            IsAlive(15);
            CanBeUsedNonCombat("used to reduce insect populations.");
            ItemDescription("a small bird with brown feathers");
        }
    }
}
