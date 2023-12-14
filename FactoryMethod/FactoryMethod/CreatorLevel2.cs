namespace FactoryMethod;

public class CreatorLevel2:Creator
{
    public override Product Create()
    {
        var product = new ProductLevel2();
        product.Name = "Продукт 2";
        return product;
    }
}