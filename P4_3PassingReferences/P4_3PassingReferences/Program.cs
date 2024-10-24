using P4_3PassingReferences;

internal class Program
{
    static void Sell(House ownerChange)
        {
        ownerChange.owner = "alex";
        }

private static void Main(string[] args)
    {
        House newHouse = new House();
        newHouse.owner = "marc";
        newHouse.PrintOwner();
        Sell(newHouse);
        newHouse.PrintOwner();


        
    }
}