using MarsRover.Model;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {

            var serviceProvider = new ServiceCollection()
                .AddSingleton<IRoverCommandValidator, RoverCommandValidator>()
                .BuildServiceProvider();

            var validator = serviceProvider.GetService<IRoverCommandValidator>();

            string Rover1Command = "LMLMLMLMM";
            string Rover2Command = "MMRMMRMRRM";

            validator.Validate(Rover1Command);
            validator.Validate(Rover2Command);

            Plateau plateau = new Plateau(5, 5);

            Rover rover1 = new Rover(1, 2, "N", plateau);
            rover1.ReadCommands(Rover1Command);
            Console.WriteLine(rover1.GetCurrentLocation());

            Rover rover2 = new Rover(3, 3, "E", plateau);
            rover2.ReadCommands(Rover2Command);
            Console.WriteLine(rover2.GetCurrentLocation());
        }
    }
}
