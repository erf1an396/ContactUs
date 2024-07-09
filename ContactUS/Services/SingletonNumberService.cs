namespace ConatactUs.Services;

public class SingletonNumberService : ISingletonNumberService
{
    private int _number;

    public SingletonNumberService()
    {
        var random = new Random();
        _number = random.Next(0, 999999999);
    }


    public int GetNumber()
    {
        return _number;
    }


}