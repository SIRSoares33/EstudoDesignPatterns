using FactoryMethod.Factories.Creators;

namespace FactoryMethod.factories
{
    /// <summary>
    /// Factory to create a mobilia factory
    /// </summary>
    public interface IFurnitureFactoryCreator : IFactoryCreator<IFurnitureFactory>
    {
    }
}