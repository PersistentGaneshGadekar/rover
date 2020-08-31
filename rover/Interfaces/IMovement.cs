using rover.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace rover.Interfaces
{
    interface IMovement
    {
        void Process(String commands,Common common);
        void TurnLeft(Common common);
        void TurnRight(Common common);
    }
}
