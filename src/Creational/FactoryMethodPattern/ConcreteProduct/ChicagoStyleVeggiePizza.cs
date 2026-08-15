namespace DesignPatterns.Creational.FactoryMethodPattern;

public class ChicagoStyleVeggiePizza : Pizza
{
    public override string Name => "Chicago Deep Dish Veggie Pizza";

    public override void Cut()
    {
        Console.WriteLine("Cutting pizza into square slices");
    }
}
