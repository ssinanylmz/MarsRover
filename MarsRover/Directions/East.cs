using MarsRover.Enums;
using MarsRover.Interfaces;
using MarsRover.Models;

namespace MarsRover.Directions
{
	public class East : IDirection
    {
        public void ChangeDirection(Rover rover, string commandType)
        {
            rover.Direction = commandType == "L" ? Direction.N : commandType == "R" ? Direction.S : rover.Direction;
            rover.X += commandType == "M" ? 1 : 0;
        }
    }
}

