using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC_Framework
{
    /// <summary>
    /// The SMC_Simulator carried out the Monte Carlo Simulation
    /// It receives a single instance of type ISimulation
    /// and carries out this simulation multiple times
    /// and provides the required analysis
    /// </summary>
    public class SMC_Simulator
    {
        private ISimulation _simulation;
        private List<double> _simulationResults;
        public SMC_Simulator(ISimulation simulation) 
        {
            _simulation = simulation;
            _simulationResults = new List<double>();
        }


        public void Run(int n = 10000) 
        {
            // refresh and start from the beginning
            _simulationResults.Clear();

            for (int i = 0; i < n; i++)
            {
                // y_i is the result of the Random Variable from a single experiment
                double y_i = _simulation.Simulate();

                // Store this for analysis
                _simulationResults.Add(y_i);
            }
        }

        public double GetExpectedValue()
        {
            return _simulationResults.Average();
        }



    }
}
