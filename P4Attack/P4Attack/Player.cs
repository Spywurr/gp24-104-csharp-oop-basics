using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P4Attack
{
    public class Player(string Name)
    {
        public string Name = Name;
        public int Damage;
        

        public void Attack(Player target)
        {
            target.Damage++;
            
            Console.WriteLine($"{Name} attacks {target.Name}");
            Console.WriteLine($"{Name} Damage: {Damage}");
            Console.WriteLine($"{target.Name} Damage: {target.Damage}");
        }
    }
}
