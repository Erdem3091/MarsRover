using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    public interface IRoverCommandValidator
    {
        void Validate (string commands);
    }

    public class RoverCommandValidator : IRoverCommandValidator
    {
        private List<char> AllowedComands = new List<char> { 'L', 'R', 'M'};
        public void Validate(string commands)
        {
            foreach (var item in commands)
            {
                var exist = AllowedComands.Contains(item);
                if (!exist)
                {
                    throw new InvalidOperationException("Not Allowed Command Dedected");
                }
            }
        }
    }

}
