using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class Plants : AnimateObjects
    {
        public void CanBeGrown()
        {
            Console.WriteLine($"{GetType().Name} can be grown.");
        }
    }
    
}
