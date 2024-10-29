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

        /// <summary>
        /// Return mu hat (the estimate of the actual mean)
        /// </summary>
        /// <returns></returns>
        public double GetExpectedValue()
        {
            return _simulationResults.Average();
        }

        /// <summary>
        /// Estimates the variance of the simulation based on the Monte Carlo Results
        /// This estimate is unbiased
        /// </summary>
        /// <returns></returns>
        public double GetEstimatedVariance()
        {
            double estimatedMean = GetExpectedValue();

            int n = _simulationResults.Count;
            double result = 0;

            for (int i = 0; i < _simulationResults.Count;i++)
            {
                result += Math.Pow(_simulationResults[i] - estimatedMean, 2.0);
            }

            return result / (n - 1);

            double result = _simulationResults.Sum(x => (x - estimatedMean) * (x - estimatedMean));
            return result / (_simulationResults.Count - 1);
        }

        public double GetRMSE()
        {
            // sigma = sqrt( sigma squared )
            double standardDeviation = Math.Sqrt(GetEstimatedVariance());
            double n = _simulationResults.Count;
            return standardDeviation / Math.Sqrt(n);
        }

        public int FindNumberOfSimulationsToGetRMSE(double RMSE)
        {
            double sigmaSquared = GetEstimatedVariance();
            return (int)Math.Ceiling(sigmaSquared / Math.Pow(RMSE, 2.0));
        }
    }
}
