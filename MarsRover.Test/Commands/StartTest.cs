using MarsRover.Commands;
using MarsRover.Enums;
using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.Test.Commands
{
    public class StartTest
    {
        public List<Rover> rovers;
        public StartTest()
        {
            this.rovers = new List<Rover>();
        }
        [Fact]
        public void Execute_55_12N_LMLMLMLMM_ReturnLastPosition_13N()
        {
            rovers.Add(
                new Rover
                {
                    MaxCoordinatePoints = new List<int>() { 5, 5 },
                    StartPosition = new Position { X = 1, Y = 2, Direction = Direction.N },
                    Commands = "LMLMLMLMM"
                }
             );

            var result = Start.Execute(rovers);

            Assert.Equal("1 3 N", result[0]);

        }
        [Fact]
        public void Execute_55_33E_MMRMMRMRRM_ReturnLastPosition_51E()
        {
            rovers.Add(
                 new Rover
                 {
                     MaxCoordinatePoints = new List<int>() { 5, 5 },
                     StartPosition = new Position { X = 3, Y = 3, Direction = Direction.E },
                     Commands = "MMRMMRMRRM"
                 }
            );

            var result = Start.Execute(rovers);

            Assert.Equal("5 1 E", result[0]);

        }
    }
}
