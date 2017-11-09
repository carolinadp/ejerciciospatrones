using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMaps
{
    class PointLoader
    {
        private IDistanceCalculator Calculator = null;
        public PointLoader(IDistanceCalculator calculator)
        {
            this.Calculator = calculator;
        }
        
        public void LoadPoints()
        {
            List<Coordinate> points = new List<Coordinate>();
            points.Add(new Coordinate
            {
                X = 2.33,
                Y = 4.5
            });
            points.Add(new Coordinate
            {
                X = 5.33,
                Y = 7.5
            });
            points.Add(new Coordinate
            {
                X = 1,
                Y = 3
            });

            double sum = 0;
            foreach (Coordinate point in points)
            {
                double distance = this.Calculator.GetDistanceToOrigin(point);
                Console.WriteLine("la distancia fue" + distance);
                sum += distance;
            }

            Console.WriteLine("La distancia promedio " + (sum / points.Count()));
        }

    }
}
