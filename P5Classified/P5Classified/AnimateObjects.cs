using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class AnimateObjects : Description
    {
        public void IsAlive(int HP)
        {
            Console.WriteLine($"{GetType().Name} has {HP} healthpoints.");
        }
    }




    
}
