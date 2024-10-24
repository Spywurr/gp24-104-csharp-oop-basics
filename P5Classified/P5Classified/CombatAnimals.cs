using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class CombatAnimals : AnimateObjects
    {
        public void CanBeUsedForCombatAlive(int Damage)
        {
            Console.WriteLine($"{GetType().Name} can be tamed and used for combat and deals {Damage} points of damage.");
        }
    }
}
