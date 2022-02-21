using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderApp;

internal class SnakeAndLadder
{
    // Game related attributes declared here
    int position;

    // Default Constructor
    public SnakeAndLadder()
    {
        position = 0;
    }

    public void Describe()
    {
        Console.WriteLine("Position: " + position);
    }
}