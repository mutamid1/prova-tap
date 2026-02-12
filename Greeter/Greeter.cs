namespace Greeter;
using IClock;

public class Greeter
{
    private readonly IClock _clock;

    public Greeter(IClock clock)
    {
        _clock = clock;
    }

    public string GetMessage()
    {
        if (_clock.Now().Month == 1 && _clock.Now().Day == 1)
        {
            return "Buon Anno!";
        }
        return "Hello!";
    }
}