using FactoryMethod.Entities;

namespace FactoryMethod.Services
{
    /// <summary>
    /// Interface to format the mobilia list in a specific way
    /// </summary>
    public interface IRelatoryFormatter
    {
        /// <summary>
        /// Format the list of mobilia in a specific way
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mobList"></param>
        /// <returns></returns>
        Task Format(StreamWriter writer, List<IMobilia> mobList);
    }
}