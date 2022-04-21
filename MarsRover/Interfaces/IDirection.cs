using MarsRover.Enums;
using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Interfaces
{
    public interface IDirection
    {
        public void ChangeDirection(Rover rover, string commandType);
    }
}
