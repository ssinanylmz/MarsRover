using System.Collections.Generic;
using MarsRover.Directions;
using MarsRover.Interfaces;
using MarsRover.Models;

namespace MarsRover.Strategies
{
    public class DirectionStrategy
	{
		private readonly Dictionary<string, IDirection> _directoryStrategy = new Dictionary<string, IDirection>();
		public DirectionStrategy()
		{
			_directoryStrategy.Add("E", new East());
			_directoryStrategy.Add("N", new North());
			_directoryStrategy.Add("S", new South());
			_directoryStrategy.Add("W", new West());
		}
		public void ChangeDirection(string directionType,string commandType,Rover rover)
		{
			 _directoryStrategy[directionType].ChangeDirection(rover,commandType);
		}
	}
}

