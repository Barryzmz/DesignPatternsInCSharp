namespace DesignPatterns.Behavioral.StrategyPattern;

public class DecoyDuck : Duck
{
    public DecoyDuck()
        : base(
            new FlyNoWay(),
            new MuteQuack())
    {
    }

    public override string Name => "Decoy Duck";

    public override void Display()
    {
        Console.WriteLine($"I'm a {Name}.");
    }
}