using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1Replacing
{
    class Plant
    {
        public bool isGrown;


        public void Grow()
        {
            if (!isGrown)
            {
                Console.WriteLine("Plant is growing");
                isGrown = true;
            }
            else
            {
                Console.WriteLine("Plant has already grown");
            }
            
        }

        public void PrintStatus()
        {
            if (isGrown)
            {
                Console.WriteLine("Plant is a tree");
            }
            else
            {
                Console.WriteLine("Plant is a seed");
            }
        }
    }
}
