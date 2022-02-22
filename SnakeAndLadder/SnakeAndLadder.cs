using SnakeAndLadderApp;

Console.Title = "Snake & Ladder";
Console.WriteLine("------------------Snake and Ladder Simulator------------------");
SnakeAndLadder player1 = new SnakeAndLadder();
SnakeAndLadder player2 = new SnakeAndLadder();
Console.WriteLine("Player 1: ");
player1.Describe();
Console.WriteLine("Player 2: ");
player2.Describe();
player1.PlayTillEnd(player2);
Console.ReadKey();

