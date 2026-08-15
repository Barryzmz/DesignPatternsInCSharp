using DesignPatterns.Creational.SimpleFactoryMethod;

PizzaFactory factory = new PizzaFactory();

Pizza pizza = factory.CreatePizza("cheese");

pizza.Prepare();
pizza.Bake();
pizza.Cut();
pizza.Box();
