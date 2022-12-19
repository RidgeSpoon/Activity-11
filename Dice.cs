using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roll
{
    internal class Dice
    {
        private int numberOfSides; // private integer assigned the total number of sides on a die.
        private static Random rnd = new Random();// For Random number generation
        public Dice(int numberOfSides)
        {
            this.numberOfSides = numberOfSides; // Assign int param to the private in numberOfSides.
        }
        public int rollDie()
        {
            return rnd.Next(1, numberOfSides + 1); // Assigned rolled value based on a random selection between 1 - total number of sides.
        }
    }
}
