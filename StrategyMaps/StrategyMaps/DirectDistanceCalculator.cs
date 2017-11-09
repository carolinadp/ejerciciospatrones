using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMaps
{
    class DirectDistanceCalculator : IDistanceCalculator
    {
        public double GetDistanceToOrigin(Coordinate coordinate)
        {
            return Math.Sqrt(coordinate.X * coordinate.X + coordinate.Y * coordinate.Y);
        }
    }
}
