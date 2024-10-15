using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC_Framework.AreaSimulations
{
    public class HalfSquareAreaSimulator : ISimulation
    {
        private Random _r;
        public HalfSquareAreaSimulator(Random r)
        {
            _r = r;
        }

        public double Simulate()
        {
            // Select a point at random on the unit square
            double x = _r.NextDouble();
            double y = _r.NextDouble();

            // (x,y) is a point on the unit square

            // Check whether the point lies on top of the desired area
            if (x < 0.5)
            {
                // If yes, return 1
                // the point lies on the area being considered
                // green rectangle in the one note
                return 1;
            }
             else
            {
                // Else, return 0
                return 0;
            }
        }
    }
}
