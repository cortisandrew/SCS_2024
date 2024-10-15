using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC_Framework
{
    /// <summary>
    /// Represents the simulation of a random variable
    /// </summary>
    public interface ISimulation
    {
        public double Simulate();
    }
}
