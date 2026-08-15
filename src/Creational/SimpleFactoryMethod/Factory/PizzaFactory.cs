namespace DesignPatterns.Creational.SimpleFactoryMethod;

public class PizzaFactory
{
    public Pizza CreatePizza(string type)
    {
        switch (type.ToLower())
        {
            case "cheese":
                return new CheesePizza();
            case "pepperoni":
                return new PepperoniPizza();
            case "veggie":
                return new VeggiePizza();
            default:
                throw new ArgumentException($"Unknown pizza type: {type}");
        }
    }
}
