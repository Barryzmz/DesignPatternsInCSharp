namespace DesignPatterns.Creational.FactoryMethodPattern;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        switch (type.ToLower())
        {
            case "cheese":
                return new ChicagoStyleCheesePizza();
            case "pepperoni":
                return new ChicagoStylePepperoniPizza();
            case "veggie":
                return new ChicagoStyleVeggiePizza();
            default:
                throw new ArgumentException($"Unknown pizza type: {type}");
        }
    }
}
