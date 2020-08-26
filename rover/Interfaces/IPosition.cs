using rover.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace rover.Interfaces
{
    interface IPosition
    {
       void printPosition(Common common);
      Common setPosition(int x, int y, int facing );
    }
}
