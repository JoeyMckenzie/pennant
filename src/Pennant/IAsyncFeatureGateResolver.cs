namespace Pennant;

public interface IAsyncFeatureGateResolver
{
    bool ActiveAsync(string gateName);
    
    bool Inactive(string gateName);

    bool AllActive(params string[] gateNames);
    
    bool AllInactive(params string[] gateNames);

    bool SomeActive(params string[] gateNames);

    bool SomeInactive(params string[] gateNames);
}