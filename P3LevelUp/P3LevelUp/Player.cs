using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3LevelUp
{
    class Player
    {
        public int Level = 0;
        public int Experience = 0;

        public void GrantExperience(int xp)
        {
            

            Experience = Experience + xp;
            while (Experience >= 100)
            {
                Experience = Experience - 100;
                Level++;
            }
            Console.WriteLine($"{Level} Level and {Experience} Experience");

        } 
    }
}
