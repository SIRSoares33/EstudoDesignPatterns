namespace AbstractFactory.Factories.Constructors
{
    /// <summary>
    /// Cria a fábrica com base em uma entrada externa.
    /// </summary>
    public interface IConstructorsFactoryCreator
    {
        /// <summary>
        /// Cria uma fábrica com base no nome dela.
        /// </summary>
        /// <param name="constructor"></param>
        /// <returns></returns>
        IConstructorsFactory GetConstructorFactoryByString(string constructor);
    }
}