using rover.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace rover.Interfaces
{
    interface IPosition
    {
       void PrintPosition(Common common);
      Common SetPosition(int x, int y, int facing );
    }
}
