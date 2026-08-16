using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator;

public abstract class CondimentDecorator(Beverage beverage) : Beverage
{
    protected Beverage Beverage { get; } =
        beverage ?? throw new ArgumentNullException(nameof(beverage));
}
