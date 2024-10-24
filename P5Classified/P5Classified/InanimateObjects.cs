using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class InanimateObjects : Description
    {
        public void CanBeBroken(int durability)
        {
            Console.WriteLine($"{GetType().Name} has {durability} durability points.");
        }
    }
}
