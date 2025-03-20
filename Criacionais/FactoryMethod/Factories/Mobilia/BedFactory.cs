using FactoryMethod.Entities;
using FactoryMethod.factories;

namespace FactoryMethod.Factories
{
    public class BedFactory : IMobiliaFactory
    {
        public IMobilia CreateMobilia() => new Bed();
    }
}