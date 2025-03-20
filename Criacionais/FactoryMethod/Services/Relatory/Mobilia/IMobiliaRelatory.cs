using FactoryMethod.Entities;

namespace FactoryMethod.Services
{
    /// <summary>
    /// Create a relatory with the mobilia list
    /// </summary>
    public interface IMobiliaRelatory
    {
        /// <summary>
        /// Create a relatory with the mobilia list
        /// </summary>
        /// <param name="mobList"></param>
        /// <returns></returns>
        Task CreateRelatoryByList(List<IMobilia> mobList);
    }
}