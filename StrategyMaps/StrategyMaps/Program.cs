using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            IDistanceCalculator calculator = new DirectDistanceCalculator();
            PointLoader loader = new PointLoader(calculator);
            loader.LoadPoints();

            calculator = new ManhattanDistanceCalculator();
            loader = new PointLoader(calculator);
            loader.LoadPoints();

            calculator = new CornerDistanceCalculator();
            loader = new PointLoader(calculator);
            loader.LoadPoints();

            Console.ReadKey();
        }
    }
}
