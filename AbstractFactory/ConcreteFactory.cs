namespace AbstractFactory;

public class ConcreteFactoryA:AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ProductA();
    }
}