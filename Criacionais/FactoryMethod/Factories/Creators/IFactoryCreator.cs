namespace FactoryMethod.Factories.Creators
{
    public interface IFactoryCreator<Output>
    {
        Output GetFactoryByString(string input);
    }
}