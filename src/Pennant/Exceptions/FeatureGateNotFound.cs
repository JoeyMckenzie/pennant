namespace Pennant.Exceptions;

public class FeatureGateNotFound : PennantException
{
    private readonly string _featureGate;
    
    public FeatureGateNotFound(string featureGate)
    {
        _featureGate = featureGate;
    }

    public override string Message => $"Feature gate {_featureGate} was not found. Make sure to register your feature gates.";
}
