using MarsRover.Enums;
using MarsRover.Interfaces;
using MarsRover.Models;

namespace MarsRover.Directions
{
    public class North : IDirection
    {
        public void ChangeDirection(Rover rover,string commandType)
        {
            rover.Direction = commandType == "L" ? Direction.W : commandType == "R" ? Direction.E : rover.Direction;
            rover.Y += commandType == "M" ? 1 : 0;
        }
    }
}

