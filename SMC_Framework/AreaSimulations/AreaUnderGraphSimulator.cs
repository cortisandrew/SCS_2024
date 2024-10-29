using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SMC_Framework.AreaSimulations
{
    public class AreaUnderGraphSimulator : ISimulation
    {
        private Random _r;
        public AreaUnderGraphSimulator(Random r)
        {
            _r = r;
        }

        public double Simulate()
        {
            // Select a point at random on the unit square
            double x = _r.NextDouble();
            double y = _r.NextDouble();

            // f(x)
            double y_prime = x * Math.Abs(Math.Sin(10 * x));

            if (y > y_prime)
            {
                // the point does NOT fall on the shaded area
                return 0;
            }
            else
            {
                // the point lies on the shaded area
                return 1;
            }
        }
    }
}
