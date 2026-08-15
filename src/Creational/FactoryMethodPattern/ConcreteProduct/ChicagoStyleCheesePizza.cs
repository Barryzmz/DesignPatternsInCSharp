namespace DesignPatterns.Creational.FactoryMethodPattern;

public class ChicagoStyleCheesePizza : Pizza
{
    public override string Name => "Chicago Deep Dish Cheese Pizza";

    public override void Cut()
    {
        Console.WriteLine("Cutting pizza into square slices");
    }
}
