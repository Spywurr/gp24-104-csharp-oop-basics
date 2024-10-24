using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_3PassingReferences
{
    public class House
    {
        public string owner;


        public void PrintOwner()
        {
            Console.WriteLine($"This house is owned by {owner}");
        }
    }
}
