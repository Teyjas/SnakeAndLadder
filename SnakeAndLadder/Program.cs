﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderApp;

internal class SnakeAndLadder
{
    // Game related attributes declared here
    private int position;
    private bool winCheck;
    private int totalDieRoll;

    // Common Random object for the class
    static Random random = new Random();

    // Default Constructor
    public SnakeAndLadder()
    {
        position = 0;
        winCheck = false;
        totalDieRoll = 0;
    }

    public void Reset()
    {
        position = 0;
        winCheck = false;
        totalDieRoll = 0;
    }

    // Describes the players status in the game
    public void Describe()
    {
        Console.WriteLine("Position: " + position);
    }

    // Rolls die using Random
    public void RollDie()
    {
        totalDieRoll++;         // Increment totalDieRoll every RollDie is called
        int chkContinue = 0;
        int roll = random.Next(1, 7);
        Console.WriteLine("\nRolled: " + roll);
        if (winCheck is false)
            chkContinue = MovePlayer(roll);
        if (winCheck is false && chkContinue == 1)
            Option(roll);
        Describe();
    }

    // Checks option for player using Random
    private void Option(int roll)
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
        MovePlayer(-roll);
    }

    // Actions to take when option is ladder
    private void Ladder(int roll)
    {
        Console.WriteLine("Yay! A Ladder!!!");
        Console.WriteLine("Going up by " + roll);
        MovePlayer(roll);
    }

    // Checks if position is out of bounds in the game
    // Returns 1 for player to conitinue to option if not out of bounds
    // Returns 0 for player to not conitinue to option if out of bounds
    private int CheckBoundary(int displacement)
    {
        if (position < 0)
        {
            position = 0;
            return 0;
        }
        else if (position > 100)
        {
            position -= displacement;
            Console.WriteLine("Oops! You shot past position 100");
            Console.WriteLine("You are moved back to previous position");
            return 0;
        }
        else
            return 1;
    }

    // Move player acroos the board
    // Returns 1 for player to conitinue to option
    // Returns 0 for player to not conitinue to option
    private int MovePlayer(int displacement)
    {
        position += displacement;
        if (position == 100)
        {
            winCheck = true;
            return 0;
        }
        return CheckBoundary(displacement);
    }

    // This will roll die untill player wins
    public void PlayTillEnd()
    {
        while (winCheck is false)
            RollDie();
        Console.WriteLine("\nCongratulations!! You Won!!");
        Console.WriteLine("Die was rolled " + totalDieRoll + " times");
    }
}