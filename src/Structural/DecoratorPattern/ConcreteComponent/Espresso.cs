using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent;

public sealed class Espresso : Beverage
{
    public override string Description => "Espresso";

    public override decimal Cost() => 60m;
}
