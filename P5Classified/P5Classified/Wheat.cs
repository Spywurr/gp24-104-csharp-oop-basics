using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class Wheat : Plants
    {
        
        public void CanBeGrown()
        {
            Console.WriteLine($"{GetType().Name} can be grown.");
        }
    }
}

