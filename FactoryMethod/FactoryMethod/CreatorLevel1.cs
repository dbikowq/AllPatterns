namespace FactoryMethod;

public class CreatorLevel1:Creator
{
    public override Product Create()
    {
        var product = new ProductLevel1();
        product.Name = "Продукт 1";
        return product;
    }
}