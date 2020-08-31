using rover.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace rover.Classes
{
    public class Rover
    {
        readonly IMovement movement = new Movement();
        readonly IPosition position = new Position();
        Common common = null;

        public bool SetPosition(int x,int y, int facing,Plateau plateau)
        {
            if (plateau.IsCorrectPosition(x, y))
            {
                common = position.SetPosition(x, y, facing);
                return true;
            }
            return false;
        }
        
        public bool MoveRover(string movementStr, Plateau plateau)
        {
            movement.Process(movementStr, common); 
            if (plateau.IsCorrectPosition(common.x, common.y))
            {
                return true;
            }
            return false;
        }

        public void PrintPosition()
        {
            position.PrintPosition(common);
        }
    }
}
