using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator;

public sealed class Mocha(Beverage beverage) : CondimentDecorator(beverage)
{
    public override string Description => $"{Beverage.Description}, Mocha";

    public override decimal Cost() => Beverage.Cost() + 15m;
}
