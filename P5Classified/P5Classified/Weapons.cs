using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class Weapons : InanimateObjects
    {
        public void Damage(bool tool, string Description, int Damage)
        {
            if (Damage > 1)
            {
                Console.WriteLine($"{GetType().Name} does {Damage} points of damage.");
            }
           


            if (tool) Console.WriteLine($"{GetType().Name} {Description}");


        }
     
    }


    public class Shield : Weapons
    {
        public void Properties()
        {
            Damage(true, "is used to block attacks.", 0);
            ItemDescription("made of wooden boards");
        }
    }
    public class Pencil : Weapons
    {
        public void Properties()
        {
            Damage(true, "can be used for writing.", 5);
            ItemDescription("yellow");
        }
    }

}
