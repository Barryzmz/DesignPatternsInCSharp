using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;

Beverage espresso = new Espresso();
Console.WriteLine($"{espresso.Description}: NT${espresso.Cost():0.00}");

Beverage customizedCoffee = new HouseBlend();
customizedCoffee = new Mocha(customizedCoffee);
customizedCoffee = new Soy(customizedCoffee);
customizedCoffee = new Whip(customizedCoffee);

Console.WriteLine(
    $"{customizedCoffee.Description}: NT${customizedCoffee.Cost():0.00}");

Beverage doubleMocha = new Espresso();
doubleMocha = new Mocha(doubleMocha);
doubleMocha = new Mocha(doubleMocha);

Console.WriteLine($"{doubleMocha.Description}: NT${doubleMocha.Cost():0.00}");
