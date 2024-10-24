using P3_2People;




Person[] listOfNames = new Person[3];
{
    for (int i = 0; i < listOfNames.Length; i++)
    {
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();
        listOfNames[i] = new Person();
        listOfNames[i].Name = name;

    }
    
    for (int i = 0; i < listOfNames.Length; i++)
    {
        string tempname = listOfNames[i].Name;
        listOfNames[i].Greeting(tempname);
    }
           
    
}