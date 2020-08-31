using rover.Classes;
using System;
using Xunit;

namespace RoverTest
{
    public class RoverTests
    {
        [Theory]
        [InlineData(-2, 2)]
        [InlineData(2, -2)]
        [InlineData(-2, -2)]
        public void SetPlateauSizeFalseTest(int x, int y)
        {
            bool expected = false;
            Plateau plateau = new Plateau();
            bool actual = plateau.SetPlateauSize(x, y);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2)]
        [InlineData(5, 5)]
        [InlineData(0, 5)]
        [InlineData(5, 0)]
        public void SetPlateauSizeTest(int x, int y)
        {
            bool expected = true;
            Plateau plateau = new Plateau();
            bool actual = plateau.SetPlateauSize(x, y);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(5, 5)]
        [InlineData(0, 0)]
        [InlineData(5, 0)]
        public void SetPositionTest(int x, int y)
        {
            bool expected = true;
            Plateau plateau = new Plateau();
            plateau.SetPlateauSize(5, 5);
            Rover rover1 = new Rover();
            bool actual= rover1.SetPosition(x, y, Common.N, plateau);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(6, 2)]
        [InlineData(2, 6)]
        public void SetPositionFalseTest(int x, int y)
        {
            bool expected = false;
            Plateau plateau = new Plateau();
            plateau.SetPlateauSize(5, 5);
            Rover rover1 = new Rover();
            bool actual = rover1.SetPosition(x, y, Common.N, plateau);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2,1,"LMLMLMLMM")]
        [InlineData(3, 3,2,"MMRMMRMRRM")]
        public void MoveRoverTest(int x, int y,int facing,string moveStr)
        {
            bool expected = true;
            Plateau plateau = new Plateau();
            plateau.SetPlateauSize(5, 5);
            Rover rover1 = new Rover();
            rover1.SetPosition(x, y, facing, plateau);
            bool actual = rover1.MoveRover(moveStr, plateau);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(1, 2, 1, "LMMMMMMMMMMMM")]
        public void MoveRoverFailTest(int x, int y, int facing, string moveStr)
        {
            bool expected = false;
            Plateau plateau = new Plateau();
            plateau.SetPlateauSize(5, 5);
            Rover rover1 = new Rover();
            rover1.SetPosition(x, y, facing, plateau);
            bool actual = rover1.MoveRover(moveStr, plateau);
            Assert.Equal(expected, actual);
        }
    }
}
