using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_3OpenDoor
{
    class House
    {
        public void OpenDoor(bool door)
        {
            if (door)
            {
                Console.WriteLine("The door is open");
            }
            else
            {
                CloseDoor(true);
            }

        }
        public void CloseDoor(bool door)
        {
            if (door)
            {
                Console.WriteLine("The door is closed");
            }
            else
            {
                OpenDoor(true);
            }

        }



    }
}
