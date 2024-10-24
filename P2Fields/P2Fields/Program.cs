using P2Fields;

Player p1 = new Player();
p1.Name = "Marc";
p1.Email = "marc@zaku.de";
p1.Pvp = false;
p1.Vip = true;
p1.Gold = 200;
p1.Stone = 110;
p1.Wood = 53;
p1.Level = 12;
p1.Experience = 123;

Console.WriteLine("Name: " + p1.Name);
Console.WriteLine("Email: " + p1.Email);
Console.WriteLine("PvP Enabled: " + p1.Pvp);
Console.WriteLine("VIP Enabled: " + p1.Vip);
Console.WriteLine("Gold: " + p1.Gold);
Console.WriteLine("Stone: " + p1.Stone);
Console.WriteLine("Wood: " + p1.Wood);
Console.WriteLine("Level: " + p1.Level);
Console.WriteLine("Experience: " + p1.Experience);
