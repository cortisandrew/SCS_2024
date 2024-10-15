
using SMC_Framework;
using SMC_Framework.AreaSimulations;

Random r = new Random();
/*
HalfSquareAreaSimulator simulator = new HalfSquareAreaSimulator(r);
SMC_Simulator smc = new SMC_Simulator(simulator);

smc.Run(100000);

// Console.WriteLine($"The estimated area for half a unit square is {smc.GetExpectedValue()}");

QuarterAreaSimulator qa_simulator = new QuarterAreaSimulator(r);
smc = new SMC_Simulator(qa_simulator);

smc.Run(10000000);

Console.WriteLine($"The estimated area for a quarter circle {smc.GetExpectedValue()}");
Console.WriteLine($"The value should be close to {Math.PI / 4}");

Console.WriteLine($"Estimate for Pi is {smc.GetExpectedValue() * 4}");
Console.WriteLine($"Actual value for Pi {Math.PI}");
*/

AreaUnderGraphSimulator simulator = new AreaUnderGraphSimulator(r);
SMC_Simulator smc = new SMC_Simulator(simulator);

smc.Run(1000000);
Console.WriteLine(smc.GetExpectedValue());
