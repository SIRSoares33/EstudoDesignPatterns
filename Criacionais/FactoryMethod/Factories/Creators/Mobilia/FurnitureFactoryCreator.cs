namespace FactoryMethod.factories
{
    /// <summary>
    /// Factory creator to create the mobilia factory
    /// </summary>
    public class FurnitureFactoryCreator : IFurnitureFactoryCreator
    {
        #region Attributes
        /// <summary>
        /// Dictionary to store the mobilia factories
        /// </summary>
        private readonly Dictionary<string, IFurnitureFactory> _furnitureFactories;
        #endregion

        #region Constructor
        public FurnitureFactoryCreator(Dictionary<string, IFurnitureFactory> furnitureFactories) => _furnitureFactories = furnitureFactories;
        #endregion 

        #region IMobiliaFactoryCreator Methods
        public IFurnitureFactory GetFactoryByString(string furnitureName)
            => _furnitureFactories.ContainsKey(furnitureName) ? _furnitureFactories[furnitureName] : throw new ArgumentException("Mobilia not found in dictionary");
        #endregion
    }
}