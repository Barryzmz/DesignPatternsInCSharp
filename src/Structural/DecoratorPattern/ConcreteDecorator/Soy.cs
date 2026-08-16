using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator;

public sealed class Soy(Beverage beverage) : CondimentDecorator(beverage)
{
    public override string Description => $"{Beverage.Description}, Soy";

    public override decimal Cost() => Beverage.Cost() + 10m;
}
