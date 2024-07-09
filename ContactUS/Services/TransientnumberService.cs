namespace ConatactUs.Services;

public class TransientnumberService : ITransientNumberService
{

    private int _number;
    public TransientnumberService()
    {
        var radnom = new Random();
        _number = radnom.Next(0,999999999);
    }

    public int GetNumber()
    {
        return _number;

    }
}