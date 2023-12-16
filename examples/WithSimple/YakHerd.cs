namespace WithSimple;

public class YakHerd
{
    private int _numberOfYaksShaved;

    public YakHerd()
    {
        _numberOfYaksShaved = 0;
    }

    public void ShaveYak()
    {
        if (_numberOfYaksShaved > 0)
        {
            _numberOfYaksShaved -= 1;
        }
    }
}