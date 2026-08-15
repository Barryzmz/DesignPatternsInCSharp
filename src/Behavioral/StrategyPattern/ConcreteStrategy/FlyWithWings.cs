namespace DesignPatterns.Behavioral.StrategyPattern;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("Flying with wings.");
    }
}