using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class Animals : AnimateObjects
    {
        public void CanBeTamed(bool CanBeTamed)
        {
            if (CanBeTamed) Console.WriteLine($"{GetType().Name} is a wild animal.");
            
        }
    }
}
