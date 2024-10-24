using P1People;
using System;



internal class Program
{
    private static void Main(string[] args)
    {
        
        Person p1 = new Person();
        p1.Name = "Carl";

        Person p2 = new Person();
        p2.Name = "Fredrik";

        Person p3 = new Person();
        p3.Name = "Marc";

        string[] people = new string[3];
        people[0] = p1.Name;
        people[1] = p2.Name;
        people[2] = p3.Name;

        foreach (var name in people)
        {
            Console.WriteLine(name);
        }

        
    }
}