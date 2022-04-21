using MarsRover.Commands;
using MarsRover.Enums;
using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.Test.Commands
{
    public class TurnRightTest
    {
        public Rover rover;
        public TurnRight turnRight;
        public TurnRightTest()
        {
            this.rover = new Rover();
            this.turnRight = new TurnRight();
        }
        [Fact]
        public void TurnRight_Run_N()
        {

            rover.Direction = Direction.N;
            turnRight.Run(rover);
            Assert.Equal(Direction.E, rover.Direction);
        }
        [Fact]
        public void TurnRight_Run_E()
        {
            rover.Direction = Direction.E;
            turnRight.Run(rover);
            Assert.Equal(Direction.S, rover.Direction);
        }
        [Fact]
        public void TurnRight_Run_W()
        {
            rover.Direction = Direction.W;
            turnRight.Run(rover);
            Assert.Equal(Direction.N, rover.Direction);
        }
        [Fact]
        public void TurnRight_Run_S()
        {
            rover.Direction = Direction.S;
            turnRight.Run(rover);
            Assert.Equal(Direction.W, rover.Direction);
        }
    }
}
