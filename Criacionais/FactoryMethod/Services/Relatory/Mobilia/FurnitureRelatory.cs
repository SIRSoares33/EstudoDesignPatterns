using FactoryMethod.Entities;

namespace FactoryMethod.Services
{
    public class FurnitureRelatory : IFurnitureRelatory
    {
        #region Attributes
        private readonly IRelatoryFormatter _formatter;
        #endregion

        #region Constructor
        public FurnitureRelatory(IRelatoryFormatter formatter) => _formatter = formatter;
        #endregion

        #region ICreateMobiliaRelatory Methods
        public Task CreateRelatoryByList(List<IFurniture> furnituries)
        {
            using StreamWriter streamWriter = new StreamWriter("Mobilia.txt");
            return _formatter.Format(streamWriter, furnituries);
        }
        #endregion
    }
}