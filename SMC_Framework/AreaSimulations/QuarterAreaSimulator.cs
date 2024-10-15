using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC_Framework.AreaSimulations
{
    public class QuarterAreaSimulator : ISimulation
    {
        private Random _r;
        public QuarterAreaSimulator(Random r)
        {
            _r = r;
        }
        public double Simulate()
        {
            // Select a point at random on the unit square
            double x = _r.NextDouble();
            double y = _r.NextDouble();

            // Math.Sqrt(x * x + y * y) is the distance of the point (x,y) from the origin
            if (Math.Sqrt(x * x + y * y) < 1)
            {
                // point lies on the area considered
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
