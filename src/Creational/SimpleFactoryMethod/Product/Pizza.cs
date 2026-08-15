namespace DesignPatterns.Creational.SimpleFactoryMethod;

public abstract class Pizza
{
    public abstract string Name { get; }

    public virtual void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
    }

    public virtual void Bake()
    {
        Console.WriteLine($"Baking {Name}");
    }

    public virtual void Cut()
    {
        Console.WriteLine($"Cutting {Name}");
    }

    public virtual void Box()
    {
        Console.WriteLine($"Boxing {Name}");
    }
}
