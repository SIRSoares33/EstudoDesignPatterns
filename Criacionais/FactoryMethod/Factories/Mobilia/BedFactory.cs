using FactoryMethod.Entities;
using FactoryMethod.factories;

namespace FactoryMethod.Factories
{
    public class BedFactory : IFurnitureFactory
    {
        public IFurniture CreateFurniture() => new Bed();
    }
}