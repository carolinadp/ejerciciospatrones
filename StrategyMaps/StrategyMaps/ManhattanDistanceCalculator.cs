using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMaps
{
    class ManhattanDistanceCalculator : IDistanceCalculator
    {
        public double GetDistanceToOrigin(Coordinate coordinate)
        {
            return Math.Abs(coordinate.X) + Math.Abs(coordinate.Y);
        }
    }
}
