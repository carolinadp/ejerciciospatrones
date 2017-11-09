using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMaps
{
    class CornerDistanceCalculator : IDistanceCalculator
    {
        public double GetDistanceToOrigin(Coordinate coordinate)
        {
            double xx = coordinate.X - 40;
            double yy = coordinate.Y - 10;
            return Math.Sqrt(xx * xx + yy * yy) + Math.Sqrt(40 * 40 + 10 * 10);
        }
    }
}
