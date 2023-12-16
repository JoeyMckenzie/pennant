using Pennant;

namespace WithSimple;

public class YakShavingService
{
    private readonly IFeatureGateResolver _features;

    public YakShavingService(IFeatureGateResolver features)
    {
        _features = features;
    }

    public void AttemptToShaveYaks()
    {
        if (_features.Active("yak-shaving") || _features.AllActive("yak-shaving", "basket-weaving"))
        {
            // Do something
        }

        if (_features.AllInactive("yak-shaving", "knitting"))
        {
            // Do something is none of the gates are active
        }
    }
}