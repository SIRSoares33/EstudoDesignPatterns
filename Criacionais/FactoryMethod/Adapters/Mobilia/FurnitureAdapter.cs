using FactoryMethod.Entities;
using FactoryMethod.factories;

namespace FactoryMethod.Adapters.Mobilia
{
    public class FurnitureAdapter : IFurnitureAdapter
    {
        public List<IFurniture> ConvertMobiliaListStringToIMobiliaList(List<string> furnitureStringList, IFurnitureFactoryCreator furnitureFactoryCreator)
        {
            var convertedMobList = new List<IFurniture>();
            
            foreach (string furniture in furnitureStringList)
            {
                if (!string.IsNullOrEmpty(furniture))
                    convertedMobList.Add(furnitureFactoryCreator.GetFactoryByString(furniture).CreateFurniture());
            }
            return convertedMobList;
        }
    }
}