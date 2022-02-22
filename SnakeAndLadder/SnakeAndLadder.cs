using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SnakeAndLadderApp;

Console.Title = "Snake & Ladder";
Console.WriteLine("------------------Snake and Ladder Simulator------------------");
SnakeAndLadder player1 = new SnakeAndLadder();
player1.Describe();
player1.RollDie();
Console.ReadKey();
