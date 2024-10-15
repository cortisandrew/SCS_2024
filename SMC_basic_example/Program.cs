// See https://aka.ms/new-console-template for more information
using SMC_basic_example;

Console.WriteLine("Hello, World!");

// r is a Subtractive LFG
// Not a very RNG!
// de-facto standard is to use a Mersenne Twister (e.g. Python random)
Random r = new Random();

Simulation sim = new Simulation(r);

// n is the number of simulations to run (i.e. n is the time)
int n = 10000;

List<double> results = new List<double>();

for (int i = 0; i < n; i++)
{
    results.Add(
        sim.Simulate());
}

Console.WriteLine($"The estimate for E(X) is {results.Average()}");
