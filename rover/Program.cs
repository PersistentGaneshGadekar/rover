using rover.Classes;
using rover.Interfaces;
using System;

namespace rover
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovement movement = new Movement();
            IPosition position = new Position();
            Common common = null;
            Console.WriteLine("============1==================");
            common = position.setPosition(1, 2, Common.N);
            movement.process("LMLMLMLMM", common);
            position.printPosition(common); // prints 1 3 N  
            Console.WriteLine("============2==================");
            common = position.setPosition(3, 3, Common.E);
            movement.process("MMRMMRMRRM", common);
            position.printPosition(common); // prints 1 3 N  
            Console.WriteLine("===============================");
            Console.ReadLine();
        }
    }
}
