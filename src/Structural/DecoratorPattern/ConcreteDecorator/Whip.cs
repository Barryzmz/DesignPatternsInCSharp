using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator;

public sealed class Whip(Beverage beverage) : CondimentDecorator(beverage)
{
    public override string Description => $"{Beverage.Description}, Whip";

    public override decimal Cost() => Beverage.Cost() + 8m;
}
