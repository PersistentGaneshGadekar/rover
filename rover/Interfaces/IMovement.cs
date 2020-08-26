using rover.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace rover.Interfaces
{
    interface IMovement
    {
        void process(String commands,Common common);
        void turnLeft(Common common);
        void turnRight(Common common);
    }
}
