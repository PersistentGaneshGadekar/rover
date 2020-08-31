using rover.Classes;
using rover.Interfaces;
using System;

namespace rover
{
    class Program
    {
        static void Main()
        {
            Plateau plateau = new Plateau();
            plateau.SetPlateauSize(5, 5);
            Rovers rovers = new Rovers();
            rovers.CreateNewRover(1, 2, Common.N, "LMLMLMLMM", plateau);
            rovers.CreateNewRover(3, 3, Common.E, "MMRMMRMRRM", plateau);
            foreach (Rover rover in rovers.GetRoverList())
            {
                rover.PrintPosition();
            }
            Console.ReadLine();
        }
    }
}
