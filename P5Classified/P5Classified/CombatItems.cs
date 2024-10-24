using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class CombatItems : InanimateObjects
    {
        public void CanBeUsedForCombat()
        {
            Console.WriteLine($"{GetType().Name} can be used in combat.");
        }
            
    }
}
