using rover.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace rover.Classes
{
    class Movement : IMovement
    {
        public void process(string commands,Common common)
        {
            for (int idx = 0; idx < commands.Length; idx++)
            {
                process(commands[idx], common);
            }
        }
        private void process(char command, Common common)
        {
            if (command.Equals('L'))
            {
                turnLeft(common);
            }
            else if (command.Equals('R'))
            {
                turnRight(common);
            }
            else if (command.Equals('M'))
            {
                move(common);
            }
            else
            {
                throw new Exception("Speak in Mars language, please!");
            }
        }
        public void turnLeft( Common common)
        {
            common.facing = (common.facing - 1) < Common.N ? Common.W : common.facing - 1;
        }

        public void turnRight( Common common)
        {
            common.facing = (common.facing + 1) > Common.W ? Common.N : common.facing + 1;
        }

        private void move(Common common)
        {
            if (common.facing == Common.N)
            {
                common.y++;
            }
            else if (common.facing == Common.E)
            {
                common.x--;
            }
            else if (common.facing == Common.S)
            {
                common.y--;
            }
            else if (common.facing == Common.W)
            {
                common.x++;
            }
        }
    }
}
