using P4Attack;

Player player1 = new Player("Player 1");
Player player2 = new Player("Player 2");


player1.Attack(player2);
player2.Attack(player1);
player1.Attack(player1);


Player player3 = player1;

player2.Attack(player3);
Console.WriteLine(player3.Damage);

