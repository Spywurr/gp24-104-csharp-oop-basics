using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class Flowers : Plants
    {
        public void CanBeUsed(string description, int heal)
        {
            Console.WriteLine($"{GetType().Name} {description} {heal} healthpoints.");
        }
    }
    public class Dandelion : Flowers
    {
        public void Properties()
        {
            IsAlive(1);
            CanBeGrown();
            CanBeUsed("can be used to heal for", 250);
            ItemDescription("green stalk and yellow flowerbud");
            
        }
    }
    public class Tulip : Flowers
    {
        public void Properties()
        {
            IsAlive(1);
            CanBeGrown();
            CanBeUsed("can be used to heal for", 50);
            ItemDescription("green stalk and red or yellow flowerbuds");

        }
    }
}
