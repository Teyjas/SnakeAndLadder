using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderApp;

internal class SnakeAndLadder
{
    // Game related attributes declared here
    private int position;

    // Common Random object for the class
    static Random random = new Random();

    // Default Constructor
    public SnakeAndLadder()
    {
        position = 0;
    }

    public void Describe()
    {
        Console.WriteLine("Position: " + position);
    }

    public void RollDie()
    {
        int roll = random.Next(1, 7);
        Console.WriteLine("Rolled: " + roll);
        position += roll;
        Describe();
    }
}