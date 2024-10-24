using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5Classified
{
    public class Description // Description is the top level in the hierarchy, all objects have a description
    {
       
        public void ItemDescription(string Description)
        {
            Console.WriteLine($"{GetType().Name} is {Description}.");
            Console.WriteLine(""); // Break between each item
        }
    }
}
