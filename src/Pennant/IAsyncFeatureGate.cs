namespace Pennant;

/// <summary>
/// A feature gate allows application code to define individual gates
/// with encapsulated logic for determining the runtime context of a piece of code.
/// </summary>
public interface IAsyncFeatureGate : INamedFeatureGate
{
    Task<bool> ActiveAsync(CancellationToken cancellationToken = default);
}