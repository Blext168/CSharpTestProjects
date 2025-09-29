namespace CreationalPatterns.FactoryMethod;

public class MentoringFactory : IProductFactory
{
    public IProduct CreateProduct()
    {
        return new MentoringOpportunity();
    }
}