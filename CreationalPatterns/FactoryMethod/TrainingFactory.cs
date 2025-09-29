namespace CreationalPatterns.FactoryMethod;

public class TrainingFactory : IProductFactory
{
    public IProduct CreateProduct()
    {
        return new TrainingOffering();
    }
}