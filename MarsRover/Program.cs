using MarsRover.Commands;
using MarsRover.Enums;
using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rovers = CreateRovers();

            Start.Execute(rovers);

            Console.ReadLine();
        }
        private static List<Rover> CreateRovers()
        {
            List<Rover> rovers = new List<Rover>();
            var _MaxCoordinatePoints = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            do
            {
                var rover = new Rover();
                rover.MaxCoordinatePoints = _MaxCoordinatePoints;

                var _startPositions = Console.ReadLine().Trim().Split(' ');
                if (_startPositions.Count() > 3)
                    throw new Exception("Wrong Start Points");
                rover.StartPosition = new Position { X = Convert.ToInt32(_startPositions[0]), Y = Convert.ToInt32(_startPositions[1]), Direction = (Direction)Enum.Parse(typeof(Direction), _startPositions[2]) };

                rover.Commands = Console.ReadLine().ToUpper();
                rovers.Add(rover);

            } while (rovers.Count < 2);

            return rovers;
        }
    }
}
