using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover.Commands
{
    public abstract class Start
    {
        public static List<string> Execute(List<Rover> rovers)
        {
            List<string> result = new List<string>();
            rovers.ForEach(rover =>
            {
                rover.Commands.ToCharArray().ToList().ForEach(command =>
                {
                    rover.Run(command.ToString(), rover);

                    if (rover.X < 0 || rover.X > rover.MaxCoordinatePoints[0] || rover.Y < 0 || rover.Y > rover.MaxCoordinatePoints[1])
                        throw new Exception($"Location cannot be outside of coordinates (0 , 0) and ({rover.MaxCoordinatePoints[0]} , {rover.MaxCoordinatePoints[1]})");
                    else if (rovers.Where(x => x.X.Equals(rover.X) && x.Y.Equals(rover.Y)).Count() > 1)
                        throw new Exception("Oops! Rovers crashed");
                });
                Console.WriteLine(rover.X + " " + rover.Y + " " + rover.Direction);
                result.Add(rover.X + " " + rover.Y + " " + rover.Direction);
            });

            return result;
        }
    }
}
