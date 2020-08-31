using rover.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace rover.Classes
{
    class Position : IPosition
    {
        public void PrintPosition(Common common)
        {

            char dir = 'N';
            if (common.facing == 1)
            {
                dir = 'N';
            }
            else if (common.facing == 2)
            {
                dir = 'E';
            }
            else if (common.facing == 3)
            {
                dir = 'S';
            }
            else if (common.facing == 4)
            {
                dir = 'W';
            }
            if(common.x<= 5 && common.y <= 5)
            {
                Console.WriteLine(common.x + " " + common.y + " " + dir);
            }
        }

        public Common SetPosition(int x, int y, int facing )
        {
            Common common = new Common();
            common.x = x;
            common.y = y;
            common.facing = facing;
            return common;
        }
    }
}
