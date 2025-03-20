using FactoryMethod.Entities;

namespace FactoryMethod.factories
{
    /// <summary>
    /// Factory to create a sofa
    /// </summary>
    public class SofaFactory : IMobiliaFactory
    {
        public IMobilia CreateMobilia() => new Sofa();
    }
}