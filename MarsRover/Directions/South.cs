using MarsRover.Enums;
using MarsRover.Interfaces;
using MarsRover.Models;

namespace MarsRover.Directions
{
    public class South : IDirection
    {
        public void ChangeDirection(Rover rover,string commandType)
        {
            rover.Direction = commandType == "L" ? Direction.E : commandType == "R" ? Direction.W : rover.Direction;
            rover.Y -= commandType == "M" ? 1 : 0;
        }
    }
}

