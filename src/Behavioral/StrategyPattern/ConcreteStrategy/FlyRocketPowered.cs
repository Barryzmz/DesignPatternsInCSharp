namespace DesignPatterns.Behavioral.StrategyPattern;

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("Flying with a rocket!");
    }
}