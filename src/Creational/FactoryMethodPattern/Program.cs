using DesignPatterns.Creational.FactoryMethodPattern;

PizzaStore newYorkStore = new NYPizzaStore();
PizzaStore chicagoStore = new ChicagoPizzaStore();

Console.WriteLine("=== New York Store ===");
newYorkStore.OrderPizza("cheese");
Console.WriteLine("--- Next Order ---");
newYorkStore.OrderPizza("pepperoni");
Console.WriteLine("--- Next Order ---");
newYorkStore.OrderPizza("veggie");

Console.WriteLine("\n========================================\n");

Console.WriteLine("=== Chicago Store ===");
chicagoStore.OrderPizza("cheese");
Console.WriteLine("--- Next Order ---");
chicagoStore.OrderPizza("pepperoni");
Console.WriteLine("--- Next Order ---");
chicagoStore.OrderPizza("veggie");
