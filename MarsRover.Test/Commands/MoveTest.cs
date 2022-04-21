using MarsRover.Commands;
using MarsRover.Enums;
using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.Test.Commands
{
    public class MoveTest
    {
        public Rover rover;
        public Move move;
        public MoveTest()
        {
            this.rover = new Rover();
            this.move = new Move();
        }
        [Fact]
        public void Move_Run_N()
        {
            rover.Direction = Direction.N;
            move.Run(rover);
            Assert.Equal(1, rover.Y);
        }
        [Fact]
        public void Move_Run_E()
        {
            rover.Direction = Direction.E;
            move.Run(rover);
            Assert.Equal(1, rover.X);
        }
        [Fact]
        public void Move_Run_W()
        {
            rover.Direction = Direction.W;
            move.Run(rover);
            Assert.Equal(-1, rover.X);
        }
        [Fact]
        public void Move_Run_S()
        {
            rover.Direction = Direction.S;
            move.Run(rover);
            Assert.Equal(-1, rover.Y);
        }
    }
}

