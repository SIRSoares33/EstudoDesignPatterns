using FactoryMethod.Entities;

public interface IMainModel
    {
        /// <summary>
        /// Convert the mobilia list to a list of IMobilia objects
        /// </summary>
        /// <param name="furnituriesInString"></param>
        /// <returns></returns>
        Task<List<IFurniture>> ConvertMobiliaListStringToIFurnitureList(List<string> furnituriesInString);
        /// <summary>
        /// Send the mobilia list to a file
        /// </summary>
        /// <param name="mobList"></param>
        /// <returns></returns>
        Task CreateFurnitureRelatory(List<IFurniture> furnituries);
    }