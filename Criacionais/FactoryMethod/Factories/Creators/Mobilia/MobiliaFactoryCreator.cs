namespace FactoryMethod.factories
{
    /// <summary>
    /// Factory creator to create the mobilia factory
    /// </summary>
    public class MobiliaFactoryCreator : IMobiliaFactoryCreator
    {
        #region Attributes
        /// <summary>
        /// Dictionary to store the mobilia factories
        /// </summary>
        private readonly Dictionary<string, IMobiliaFactory> _mobiliaFactories;
        #endregion

        #region Constructor
        public MobiliaFactoryCreator(Dictionary<string, IMobiliaFactory> mobiliaFactories) => _mobiliaFactories = mobiliaFactories;
        #endregion 

        #region IMobiliaFactoryCreator Methods
        public IMobiliaFactory GetFactoryByString(string mobilia)
            => _mobiliaFactories.ContainsKey(mobilia) ? _mobiliaFactories[mobilia] : throw new ArgumentException("Mobilia not found in dictionary");
        #endregion
    }
}