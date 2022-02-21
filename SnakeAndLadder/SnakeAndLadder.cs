using SnakeAndLadderApp;

Console.Title = "Snake & Ladder";
Console.WriteLine("------------------Snake and Ladder Simulator------------------");
SnakeAndLadder player1 = new SnakeAndLadder();
player1.Describe();
player1.RollDie();
player1.Describe();
Console.ReadKey();