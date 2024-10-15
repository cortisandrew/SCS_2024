using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC_basic_example
{
    public class Simulation
    {
        private Random _r;
        public Simulation(Random r) {
            _r = r;
        }

        /// <summary>
        /// Returns the result of X(E), for a randomly selected event
        /// The selection of the event depends on the experiment that
        /// X is representing
        /// </summary>
        /// <returns></returns>
        public double Simulate()
        {
            double p = _r.NextDouble();

            if (p < 0.25)
            {
                // HH - event 
                return 3.5;
            }
            else if (p < 0.75)
            {
                //HT or TH
                return -1;
            }
            else
            {
                // TT
                return -2;
            }
        }
    }
}
