using System.Collections.Generic;
using MarsRover.Commands;
using MarsRover.Interfaces;
using MarsRover.Models;

namespace MarsRover.Strategies
{
    public class RoverStrategy : Position
    {
        private readonly Dictionary<string, IRover> _roverStrategy = new Dictionary<string, IRover>();

        public RoverStrategy()
        {
            _roverStrategy.Add("L", new TurnLeft());
            _roverStrategy.Add("R", new TurnRight());
            _roverStrategy.Add("M", new Move());
        }
        public void Run(string commandType,Rover rover)
        {
            _roverStrategy[commandType].Run(rover);
        }
    }
}

