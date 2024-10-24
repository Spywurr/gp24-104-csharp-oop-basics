using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class CombatBirds : Animals
    {
        public void CanFly()
        {
            Console.WriteLine($"{GetType().Name} can fly.");
        }
    }
    
    public class Hawk : CombatBirds
    {
        public void Properties()
        {
            CanFly();
            CanBeTamed(true);
            ItemDescription("a medium sized bird with brown feathers");
        }
    }
    
}
