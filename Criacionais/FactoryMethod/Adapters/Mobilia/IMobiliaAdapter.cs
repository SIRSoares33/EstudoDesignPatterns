using FactoryMethod.Entities;
using FactoryMethod.factories;

namespace FactoryMethod.Adapters.Mobilia
{
    /// <summary>
    /// Adapter to convert the mobilia list to a list of IMobilia objects
    /// </summary>
    public interface IMobiliaAdapter
    {
        /// <summary>
        /// Convert the mobilia list to a list of IMobilia objects
        /// </summary>
        /// <param name="mobiliaStringList"></param>
        /// <returns></returns>
        List<IMobilia> ConvertMobiliaListStringToIMobiliaList(List<string> mobiliaStringList, IMobiliaFactoryCreator mobiliaFactoryCreator);
    }
}