using FactoryMethod.Entities;

namespace FactoryMethod.Services
{
    public class MobiliaRelatory : IMobiliaRelatory
    {
        #region Attributes
        private readonly IRelatoryFormatter _formatter;
        #endregion

        #region Constructor
        public MobiliaRelatory(IRelatoryFormatter formatter) => _formatter = formatter;
        #endregion

        #region ICreateMobiliaRelatory Methods
        public Task CreateRelatoryByList(List<IMobilia> mobList)
        {
            using StreamWriter streamWriter = new StreamWriter("Mobilia.txt");
            return _formatter.Format(streamWriter, mobList);
        }
        #endregion
    }
}