using FactoryMethod.Entities;

namespace FactoryMethod.factories
{
    /// <summary>
    /// Factory to create a mobilia
    /// </summary>
    public interface IFurnitureFactory
    {
        IFurniture CreateFurniture();
    }
}