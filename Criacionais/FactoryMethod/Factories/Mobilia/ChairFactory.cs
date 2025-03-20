using FactoryMethod.Entities;

namespace FactoryMethod.factories.Mobilia
{
    /// <summary>
    /// Factory to create a chair
    /// </summary>
    public class ChairFactory : IFurnitureFactory
    {
        public IFurniture CreateFurniture() => new Chair();
    }
}