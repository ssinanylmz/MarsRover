using MarsRover.Strategies;
using System.Collections.Generic;

namespace MarsRover.Models
{
    public class Rover : RoverStrategy
    {
        public List<int> MaxCoordinatePoints { get; set; }

        private Position _StartPosition=null;
        public Position StartPosition
        {
            get { return _StartPosition; }
            set
            {
                X = value.X;
                Y = value.Y;
                Direction = value.Direction;
            }
        }
        public string Commands { get; set; }

    }
}
