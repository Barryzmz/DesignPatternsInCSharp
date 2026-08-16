namespace DecoratorPattern.Component;

public abstract class Beverage
{
    public abstract string Description { get; }

    public abstract decimal Cost();
}
