using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class Foods : Plants
    {
        public void CanBeEaten(bool Heal, int AmountHealed)
        {
            Console.WriteLine($"{GetType().Name} can be eaten.");
            if (Heal)
            {
                Console.WriteLine($"{GetType().Name} heals for {AmountHealed}.");
            }
        }
            
    }
    
    public class Bread : Foods
    {
        public void Properties()
        {
            CanBeEaten(true, 50);
            ItemDescription("brown");
        }

    }

}

