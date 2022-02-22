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

    // Describes the players status in the game
    public void Describe()
    {
        Console.WriteLine("Position: " + position);
    }

    // Rolls die using Random
    public void RollDie()
    {
        int roll = random.Next(1, 7);
        Console.WriteLine("Rolled: " + roll);
        position += roll;
        Option(roll);
        Describe();
    }

    // Checks option for player using Random
    public void Option(int roll)
    {
        int option = random.Next(0, 3);
        switch (option)
        {
            case 0:
                Console.WriteLine("No Play");
                break;
            case 1:
                Ladder(roll);
                break;
            case 2:
                Snake(roll);
                break;
            default:
                Console.WriteLine("Error!");
                break;
        }
    }

    // Actions to take when option is snake
    private void Snake(int roll)
    {
        Console.WriteLine("Oops! Snake Trap!!!");
        Console.WriteLine("Going down by " + roll);
        position -= roll;
    }

    // Actions to take when option is ladder
    private void Ladder(int roll)
    {
        Console.WriteLine("Yay! A Ladder!!!");
        Console.WriteLine("Going up by " + roll);
        position += roll;
    }
}