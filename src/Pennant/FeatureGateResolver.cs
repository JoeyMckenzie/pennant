using Pennant.Exceptions;

namespace Pennant;

/// <summary>
/// A feature represents a flag or gate within an application's logic.
/// Features check for conditions to determine if a piece of code is executable
/// based on predicates passed in from calling code.
/// </summary>
internal class FeatureGateResolver : IFeatureGateResolver
{
    private ICollection<IFeatureGate> _featureGates;
    private ICollection<IAsyncFeatureGate> _asyncFeatureGates;

    public FeatureGateResolver()
    {
        _featureGates = new List<IFeatureGate>();
        _asyncFeatureGates = new List<IAsyncFeatureGate>();
    }

    public FeatureGateResolver WithFeatureGate(IFeatureGate featureGate)
    {
        _featureGates.Add(featureGate);
        return this;
    }

    public FeatureGateResolver WithAsyncFeatureGate(IAsyncFeatureGate featureGate)
    {
        _asyncFeatureGates.Add(featureGate);
        return this;
    }

    public Task<bool> ResolveFeatureGate(string featureGateName)
    {
        // First, check for the sync feature gates
        var feature = _featureGates.FirstOrDefault(fg => 
            string.Equals(featureGateName, fg.Name, StringComparison.CurrentCultureIgnoreCase));
        
        if (feature is not null)
        {
            return Task.FromResult(feature.Active());
        }
        
        // No sync features matched, so let's go through the async features
        var asyncFeature = _asyncFeatureGates.FirstOrDefault(fg =>
            string.Equals(featureGateName, fg.Name, StringComparison.CurrentCultureIgnoreCase));

        if (asyncFeature is null)
        {
            throw new FeatureGateNotFound(featureGateName);
        }

        return asyncFeature.ActiveAsync();
    }

    public bool Active(string gateName)
    {
        throw new NotImplementedException();
    }

    public bool Inactive(string gateName)
    {
        throw new NotImplementedException();
    }

    public bool AllActive(params string[] gateNames)
    {
        throw new NotImplementedException();
    }

    public bool AllInactive(params string[] gateNames)
    {
        throw new NotImplementedException();
    }

    public bool SomeActive(params string[] gateNames)
    {
        throw new NotImplementedException();
    }

    public bool SomeInactive(params string[] gateNames)
    {
        throw new NotImplementedException();
    }
}