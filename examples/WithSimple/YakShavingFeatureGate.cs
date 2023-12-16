using Pennant;

namespace WithSimple;

public class YakShavingFeatureGate : IFeatureGate
{
    public string Name => "yak-shaving";
    
    private readonly YakHerd _yakHerd;
    private readonly bool _scissorsAreFound;

    public YakShavingFeatureGate()
    {
        _yakHerd = yakHerd;
        _scissorsAreFound = scissorsAreFound;
    }

    public YakShavingFeatureGate(YakHerd yakHerd, bool scissorsAreFound)
    {
        _yakHerd = yakHerd;
        _scissorsAreFound = scissorsAreFound;
    }

    public bool Active() => resolv;
}