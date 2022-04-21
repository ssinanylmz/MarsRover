using MarsRover.Enums;
using MarsRover.Interfaces;
using MarsRover.Models;

namespace MarsRover.Directions
{
    public class West : IDirection
    {
        public void ChangeDirection(Rover rover,string commandType)
        {
            rover.Direction = commandType == "L" ? Direction.S : commandType=="R" ? Direction.N : rover.Direction;
            rover.X -= commandType == "M" ? 1 : 0;
        }
    }
}

