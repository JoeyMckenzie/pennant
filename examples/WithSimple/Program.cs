using Pennant;
using WithSimple;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var yakHerd = new YakHerd();
var featureGate = new YakShavingFeatureGate("yakShaving");

if (featureGate.Active())
{
    yakHerd.ShaveYak();
}
else
{
    Console.WriteLine("There's no scissors to shave the yaks!");
}