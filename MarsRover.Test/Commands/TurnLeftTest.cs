using MarsRover.Commands;
using MarsRover.Enums;
using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.Test.Commands
{
    public class TurnLeftTest
    {
        public Rover rover;
        public TurnLeft turnLeft;
        public TurnLeftTest()
        {
            this.rover = new Rover();
            this.turnLeft = new TurnLeft();
        }
        [Fact]
        public void TurnLeft_Run_N()
        {
            rover.Direction = Direction.N;
            turnLeft.Run(rover);
            Assert.Equal(Direction.W, rover.Direction);
        }
        [Fact]
        public void TurnLeft_Run_E()
        {
            rover.Direction = Direction.E;
            turnLeft.Run(rover);
            Assert.Equal(Direction.N, rover.Direction);
        }
        [Fact]
        public void TurnLeft_Run_W()
        {
            rover.Direction = Direction.W;
            turnLeft.Run(rover);
            Assert.Equal(Direction.S, rover.Direction);
        }
        [Fact]
        public void TurnLeft_Run_S()
        {
            rover.Direction = Direction.S;
            turnLeft.Run(rover);
            Assert.Equal(Direction.E, rover.Direction);
        }
    }
}
