namespace AbstractFactory;

public class ClientFactory
{
    public ClientFactory(AbstractFactory factory)
    {
        factory.CreateProductA();
    }
}