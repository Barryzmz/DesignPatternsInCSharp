namespace DesignPatterns.Creational.FactoryMethodPattern;

public class ChicagoStylePepperoniPizza : Pizza
{
    public override string Name => "Chicago Deep Dish Pepperoni Pizza";

    public override void Cut()
    {
        Console.WriteLine("Cutting pizza into square slices");
    }
}
