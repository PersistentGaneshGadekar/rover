using System;
using System.Collections.Generic;
using System.Text;

namespace rover.Classes
{
    public class Rovers
    {
        List<Rover> listRovers = new List<Rover>();
        public List<Rover> CreateNewRover(int x, int y, int facing, string moveString,Plateau plateau)
        {
            Rover rover1 = new Rover();
            
            rover1.SetPosition(x,y, facing, plateau);
            rover1.MoveRover(moveString, plateau);
            //rover1.PrintPosition();
            listRovers.Add(rover1);
            return listRovers;
        }
        public List<Rover> GetRoverList()
        {
            return listRovers;
        }

    }
}
