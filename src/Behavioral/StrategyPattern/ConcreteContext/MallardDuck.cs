namespace DesignPatterns.Behavioral.StrategyPattern;

public class MallardDuck : Duck
{
    public MallardDuck(): base(
            new FlyWithWings(),
            new NormalQuack())
    {
    }

    public override string Name => "Mallard Duck";

    public override void Display()
    {
        Console.WriteLine($"I'm a {Name}.");
    }
}
