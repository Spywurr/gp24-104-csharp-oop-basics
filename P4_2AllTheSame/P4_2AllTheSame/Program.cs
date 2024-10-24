using P4_2AllTheSame;

ScoreCounter one = new ScoreCounter();
var two = one;
var three = two;
var four = three;

four.IncreaseScore(1);
three.IncreaseScore(1);
two.IncreaseScore(1);
one.IncreaseScore(1);

Console.WriteLine(one.score);
Console.WriteLine(two.score);
Console.WriteLine(three.score);
Console.WriteLine(four.score);