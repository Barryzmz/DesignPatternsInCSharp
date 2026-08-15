namespace DesignPatterns.Behavioral.StrategyPattern;

public class RubberDuck : Duck
{
    public RubberDuck()
        : base(
            new FlyNoWay(),
            new Squeak())
    {
    }

    public override string Name => "Rubber Duck";

    public override void Display()
    {
        Console.WriteLine($"I'm a {Name}.");
    }
}