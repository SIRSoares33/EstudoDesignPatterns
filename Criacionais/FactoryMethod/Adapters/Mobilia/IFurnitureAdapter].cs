using FactoryMethod.Entities;
using FactoryMethod.factories;

namespace FactoryMethod.Adapters.Mobilia
{
    /// <summary>
    /// Adapter to convert the mobilia list to a list of IMobilia objects
    /// </summary>
    public interface IFurnitureAdapter
    {
        /// <summary>
        /// Convert the mobilia list to a list of IMobilia objects
        /// </summary>
        /// <param name="furnitureStringList"></param>
        /// <returns></returns>
        List<IFurniture> ConvertMobiliaListStringToIMobiliaList(List<string> furnitureStringList, IFurnitureFactoryCreator furnitureFactoryCreator);
    }
}