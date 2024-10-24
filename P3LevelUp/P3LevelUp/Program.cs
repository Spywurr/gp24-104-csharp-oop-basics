using P3LevelUp;

Player p1 = new Player();


while(true)
{
    Console.WriteLine("How much experience would you like to add?");
    int experienceAdded = Convert.ToInt32(Console.ReadLine());
    p1.GrantExperience(experienceAdded);
}
