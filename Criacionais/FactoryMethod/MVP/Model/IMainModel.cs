using FactoryMethod.Entities;

public interface IMainModel
    {
        /// <summary>
        /// Convert the mobilia list to a list of IMobilia objects
        /// </summary>
        /// <param name="mobList"></param>
        /// <returns></returns>
        Task<List<IMobilia>> ConvertMobiliaListStringToIMobiliaList(List<string> mobList);
        /// <summary>
        /// Send the mobilia list to a file
        /// </summary>
        /// <param name="mobList"></param>
        /// <returns></returns>
        Task CreateRelatory(List<IMobilia> mobList);
    }