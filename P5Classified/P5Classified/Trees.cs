using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class Trees : Plants
    {
        public void CanBeUsed(string usage)
        {

            Console.WriteLine($"{GetType().Name} can be used for {usage}");
            ItemDescription("has brown bark and green leaves");
        }
    }
    public class Oak : Trees
    {
        public void Properties()
        {
            IsAlive(500);
            CanBeGrown();
            CanBeUsed($"firewood or to build other objects (Shield, spear etc)");
            
        }
    }
    public class Fir : Trees
    {
        public void Properties()
        {
            IsAlive(250);
            CanBeGrown();
            CanBeUsed($"firewood or to build other objects (Shield, spear etc)");
        }
    }

}
