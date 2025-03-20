using FactoryMethod.Entities;

namespace FactoryMethod.factories.Mobilia
{
    /// <summary>
    /// Factory to create a table
    /// </summary>
    public class TableFactory : IMobiliaFactory
    {
        public IMobilia CreateMobilia() => new Table();
    }
}