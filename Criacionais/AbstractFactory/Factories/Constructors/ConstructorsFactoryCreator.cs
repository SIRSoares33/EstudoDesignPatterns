using AbstractFactory.Factories.Constructors;

namespace AbstractFactory.Factories
{
    public class ConstructorsFactoryCreator(Dictionary<string, IConstructorsFactory> constructors) : IConstructorsFactoryCreator
    {
        #region Factories
        private readonly Dictionary<string, IConstructorsFactory> _constructors = constructors;
        #endregion

        #region IConstructorsFactoryCreator Methods
        public IConstructorsFactory GetConstructorFactoryByString(string constructorName)
            => _constructors.ContainsKey(constructorName) ? _constructors[constructorName] 
            : throw new Exception("Constructor not found");
        #endregion
    }
}