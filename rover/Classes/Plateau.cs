using System;
using System.Collections.Generic;
using System.Text;

namespace rover.Classes
{
    public class Plateau
    {
        public int x;
        public int y;

        public Plateau( )
        {
        }
        public bool SetPlateauSize(int x, int y)
        {
            if (x >= 0 && y >= 0)
            {
                this.x = x;
                this.y = y;
                return true;
            }
            return false;
            
        }
        public bool IsCorrectPosition(int x, int y)
        {
            if(x >=0 && x <= this.x && y>=0 && y <= this.y)
            {
                return true;
            }
            return false;
        }
    }
}
