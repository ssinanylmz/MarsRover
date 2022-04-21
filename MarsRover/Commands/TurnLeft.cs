using MarsRover.Interfaces;
using MarsRover.Models;
using MarsRover.Strategies;

namespace MarsRover.Commands
{
    public class TurnLeft : IRover
    {
        public void Run(Rover rover)
        {
            DirectionStrategy direction = new DirectionStrategy();
            direction.ChangeDirection(rover.Direction.ToString(),"L",rover);
        }
    }
}

