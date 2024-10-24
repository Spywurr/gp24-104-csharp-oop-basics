using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class Fruits : Foods
    {
    
    }
    public class Apple : Fruits
    {
        public void Properties()
        {
            CanBeGrown();
            CanBeEaten(true, 150);
            ItemDescription("red");
        }

    }
    public class Pear : Fruits
    {
        public void Properties()
        {
            CanBeGrown();
            CanBeEaten(true, 150);
            ItemDescription("green");
        }

    }
    public class Banana : Fruits
    {
        public void Properties()
        {
            CanBeGrown();
            CanBeEaten(true, 250);
            ItemDescription("yellow");
        }

    }
}
