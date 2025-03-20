using FactoryMethod.Entities;

namespace FactoryMethod.Services
{
    /// <summary>
    /// Create a relatory with the mobilia list
    /// </summary>
    public interface IFurnitureRelatory
    {
        /// <summary>
        /// Create a relatory with the mobilia list
        /// </summary>
        /// <param name="relatories"></param>
        /// <returns></returns>
        Task CreateRelatoryByList(List<IFurniture> relatories);
    }
}