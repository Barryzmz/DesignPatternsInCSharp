using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent;

public sealed class HouseBlend : Beverage
{
    public override string Description => "House Blend Coffee";

    public override decimal Cost() => 50m;
}
