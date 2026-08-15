namespace DesignPatterns.Creational.FactoryMethodPattern;

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        switch (type.ToLower())
        {
            case "cheese":
                return new NYStyleCheesePizza();
            case "pepperoni":
                return new NYStylePepperoniPizza();
            case "veggie":
                return new NYStyleVeggiePizza();
            default:
                throw new ArgumentException($"Unknown pizza type: {type}");
        }
    }
}
