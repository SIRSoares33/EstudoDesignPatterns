using FactoryMethod.Entities;
using FactoryMethod.factories;

namespace FactoryMethod.Adapters.Mobilia
{
    public class MobiliaAdapter : IMobiliaAdapter
    {
        public List<IMobilia> ConvertMobiliaListStringToIMobiliaList(List<string> mobiliaStringList, IMobiliaFactoryCreator mobiliaFactoryCreator)
        {
            var convertedMobList = new List<IMobilia>();
            
            foreach (var mobilia in mobiliaStringList)
            {
                if (!string.IsNullOrEmpty(mobilia))
                    convertedMobList.Add(mobiliaFactoryCreator.GetFactoryByString(mobilia).CreateMobilia());
            }
            return convertedMobList;
        }
    }
}