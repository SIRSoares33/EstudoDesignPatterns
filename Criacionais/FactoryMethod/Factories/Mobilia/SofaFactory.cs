using FactoryMethod.Entities;

namespace FactoryMethod.factories
{
    /// <summary>
    /// Factory to create a sofa
    /// </summary>
    public class SofaFactory : IFurnitureFactory
    {
        public IFurniture CreateFurniture() => new Sofa();
    }
}