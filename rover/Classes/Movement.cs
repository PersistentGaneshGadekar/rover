using rover.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace rover.Classes
{
    class Movement : IMovement
    {
        public void Process(string commands,Common common)
        {
            for (int idx = 0; idx < commands.Length; idx++)
            {
                Process(commands[idx], common);
            }
        }
        private void Process(char command, Common common)
        {
            if (command.Equals('L'))
            {
                TurnLeft(common);
            }
            else if (command.Equals('R'))
            {
                TurnRight(common);
            }
            else if (command.Equals('M'))
            {
                Move(common);
            }
            else
            {
                throw new Exception("Speak in Mars language, please!");
            }
        }
        public void TurnLeft( Common common)
        {
            common.facing = (common.facing - 1) < Common.N ? Common.W : common.facing - 1;
        }

        public void TurnRight( Common common)
        {
            common.facing = (common.facing + 1) > Common.W ? Common.N : common.facing + 1;
        }

        private void Move(Common common)
        {
            if (common.facing == Common.N)
            {
                common.y++;
            }
            else if (common.facing == Common.E)
            {
                common.x++;
            }
            else if (common.facing == Common.S)
            {
                common.y--;
            }
            else if (common.facing == Common.W)
            {
                common.x--;
            }
        }
    }
}
