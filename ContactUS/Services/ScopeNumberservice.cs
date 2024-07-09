namespace ConatactUs.Services;

public class ScopeNumberservice : IScopeNumberService
{
    private int _number;

    public ScopeNumberservice()
    {
        var random = new Random();
        _number = random.Next(0, 999999999);
    }

    public int GetNumber()
    {
        return _number;
    }
}