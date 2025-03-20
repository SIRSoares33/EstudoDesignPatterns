using FactoryMethod.Entities;

namespace FactoryMethod.factories.Mobilia
{
    /// <summary>
    /// Factory to create a chair
    /// </summary>
    public class ChairFactory : IMobiliaFactory
    {
        public IMobilia CreateMobilia() => new Chair();
    }
}